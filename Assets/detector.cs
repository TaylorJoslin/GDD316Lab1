using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    public float avoidanceRadius = 2f;
    public float avoidanceWeight = 1f;

    private void Update()
    {
        Vector3 avoidanceDirection = Vector3.zero;

        Collider[] colliders = Physics.OverlapSphere(transform.position, avoidanceRadius);
        foreach (Collider col in colliders)
        {
            if (col.gameObject != gameObject) // Exclude self from collision detection
            {
                Vector3 avoidanceVector = transform.position - col.transform.position;
                avoidanceDirection += avoidanceVector.normalized * avoidanceWeight;
            }
        }

        // Adjust boid's direction to avoid collisions
        transform.forward += avoidanceDirection * Time.deltaTime;

        // Apply other flocking behaviors here (alignment, cohesion, etc.)
    }
}
