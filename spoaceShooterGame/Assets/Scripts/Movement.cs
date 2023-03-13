using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
