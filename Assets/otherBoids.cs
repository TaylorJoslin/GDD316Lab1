using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherBoids : MonoBehaviour
{
  

    private void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("boid"))
        {
            other.transform.position += transform.forward * Time.deltaTime * 10;
        }
    }
}
