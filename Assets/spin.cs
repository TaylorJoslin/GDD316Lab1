using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    [SerializeField] private GameObject gb;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0.0f, 0.0f, speed);
    }
}
