using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    bool left = false;
    void Update()
    {
        Move();
    }
    void Horizontal()
    {
        if (transform.position.x > 0.9f)
        {
            left = true;
        }
        if (transform.position.x < -0.9f )
        {
            left = false;
        }
    }
    void Move()
    {
        Horizontal();
        if (left)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
