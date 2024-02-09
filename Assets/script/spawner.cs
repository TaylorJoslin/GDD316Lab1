using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   [SerializeField] private GameObject prefab;
   [SerializeField] private Transform target;
   [SerializeField] private float speed = 1f;

    

    void Start()
    {
        InstantiateObject();
    }

    void Update()
    {
        //moves the boid to the target
        if (prefab != null && target != null)
        {
            prefab.transform.position = Vector3.MoveTowards(prefab.transform.position, target.position, speed * Time.deltaTime);
            prefab.transform.LookAt(target.position);
        }

        
    }

    private void InstantiateObject()
    {
        //spawns a boid
        if (prefab != null)
        {
            prefab = Instantiate(prefab, transform.position, Quaternion.identity);
           

        }
    }
}
