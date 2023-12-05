using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    float speed = 3.0f;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
