using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

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

    //private void OnCollisionEnter(Collision other)
    //{
    //   if(other.gameObject.CompareTag("boid"))
    //    {
    //        other.transform.position += transform.forward * Time.deltaTime * 10;
    //    }
    //}

    


    private void OnDrawGizmosSelected()
    {
        if (startPoint == null)
            return;

        Gizmos.DrawWireSphere(startPoint.position, detectRange);
    }
}
