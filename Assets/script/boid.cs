using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boid : MonoBehaviour
{
    [SerializeField] private float rotationX = 0;
    [SerializeField] private float rotationY = 0;

    [SerializeField] private Transform startPoint;
    [SerializeField] private float detectRange;
    [SerializeField] private LayerMask boidLayer;

    [SerializeField] private float KnockbackForce;


    void Update()
    {
        //rotate the player
        rotationX += Time.deltaTime * 2;
        rotationY += Time.deltaTime * 2;

        float x = Mathf.Cos(rotationX);
        float y = Mathf.Sin(rotationY);
        float z = 0;

        transform.position = new Vector3(x, y, z);

        //detect other boids around the player
        Collider[] detectBoids = Physics.OverlapSphere(startPoint.position, detectRange, boidLayer);

        foreach (Collider boid in detectBoids)
        {
            //Rigidbody rb = boid.GetComponent<Rigidbody>();

            //if (rb != null)
            //{
            //    // Calculate knockback direction
            //    Vector3 knockbackDirection = transform.position - boid.transform.position;
            //    knockbackDirection.Normalize();

            //    // Apply knockback force
            //    rb.AddForce(knockbackDirection * KnockbackForce, ForceMode.Impulse);
            //}

            boid.transform.position -= transform.position.normalized * Time.deltaTime * KnockbackForce;

        }


    }

    //show range of detection
    private void OnDrawGizmosSelected()
    {
        if (startPoint == null)
            return;

        Gizmos.DrawWireSphere(startPoint.position, detectRange);
    }
}
