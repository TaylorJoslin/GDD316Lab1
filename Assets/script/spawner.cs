using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
   [SerializeField] private GameObject prefab,prefab2, prefab3, prefab4;
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

        if (prefab2 != null && target != null)
        {
            prefab2.transform.position = Vector3.MoveTowards(prefab2.transform.position, target.position, speed * Time.deltaTime);
            prefab2.transform.LookAt(target.position);
        }

        if (prefab3 != null && target != null)
        {
            prefab3.transform.position = Vector3.MoveTowards(prefab3.transform.position, target.position, speed * Time.deltaTime);
            prefab3.transform.LookAt(target.position);
        }

        if (prefab4 != null && target != null)
        {
            prefab4.transform.position = Vector3.MoveTowards(prefab4.transform.position, target.position, speed * Time.deltaTime);
            prefab4.transform.LookAt(target.position);
        }


    }

    private void InstantiateObject()
    {
        //spawns a boid
        if (prefab != null)
        {
            var spawnSpot = new Vector3(Random.Range(-7, 7), 0, (Random.Range(-7, 7)));
            prefab = Instantiate(prefab, spawnSpot, Quaternion.identity);
        }

        if (prefab2 != null)
        {
            var spawnSpot = new Vector3(Random.Range(-7, 7), 0, (Random.Range(-7, 7)));
            prefab2 = Instantiate(prefab2, spawnSpot, Quaternion.identity);
        }

        if (prefab3 != null)
        {
            var spawnSpot = new Vector3(Random.Range(-7, 7), 0, (Random.Range(-7, 7)));
            prefab3 = Instantiate(prefab3, spawnSpot, Quaternion.identity);
        }

        if (prefab4 != null)
        {
            var spawnSpot = new Vector3(Random.Range(-7, 7), 0, (Random.Range(-7, 7)));
            prefab4 = Instantiate(prefab4, spawnSpot, Quaternion.identity);
        }
    }
}
