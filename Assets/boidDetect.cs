using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boidDetect : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private float detectRange;
    [SerializeField] private LayerMask boidLayer;

    [SerializeField] private float KnockbackForce;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //detect other boids around the player
        Collider[] detectBoids = Physics.OverlapSphere(startPoint.position, detectRange, boidLayer);

        foreach (Collider boid in detectBoids)
        {

            boid.transform.position += transform.forward * Time.deltaTime * KnockbackForce;

        }
    }

   

    private void OnDrawGizmosSelected()
    {
        if (startPoint == null)
            return;

        Gizmos.DrawWireSphere(startPoint.position, detectRange);
    }
}
