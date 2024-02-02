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
            
            boid.transform.position += transform.forward * Time.deltaTime * KnockbackForce;

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
