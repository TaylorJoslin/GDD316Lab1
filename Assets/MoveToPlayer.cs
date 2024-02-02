using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveToPlayer : MonoBehaviour
{
    public GameObject prefab;
    public Transform target;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves the boid to the target
        if (prefab != null && target != null)
        {
            prefab.transform.position = Vector3.MoveTowards(prefab.transform.position, target.position, speed * Time.deltaTime);
            prefab.transform.LookAt(target.position);
        }
    }
}
