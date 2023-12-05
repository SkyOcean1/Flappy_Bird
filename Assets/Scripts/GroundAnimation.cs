using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAnimation : MonoBehaviour
{
    float speed = 4.0f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // deltaTime ������ ������ ��� �ð�

        if(transform.position.x <= -7.2)
        {
            transform.position = new Vector3(6.5f, transform.position.y, transform.position.z);
        }
    }
}
