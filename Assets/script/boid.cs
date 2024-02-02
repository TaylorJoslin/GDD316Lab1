using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boid : MonoBehaviour
{
    private float rotation = 0;


    void Update()
    {
        //rotate the boid
        rotation += Time.deltaTime * 2;

        float x = Mathf.Cos(rotation);
        float y = Mathf.Sin(rotation);
        float z = 0;

        transform.position = new Vector3(x, y, z);
    }
}
