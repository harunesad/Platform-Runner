using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 1, -2);
    void LateUpdate()
    {
        Follow();
    }
    void Follow()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime * 5);
    }
}
