using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RotatePlatform : MonoBehaviour
{
    public static RotatePlatform instance = null;
    public GameObject player;
    public float rotateSpeed;
    void Update()
    {
        Rotate();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = transform;
        }
    }
    void Rotate()
    {
        transform.Rotate(0, 0, Time.deltaTime * rotateSpeed);
    }
}
