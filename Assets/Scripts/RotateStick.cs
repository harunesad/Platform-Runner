using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStick : MonoBehaviour
{
    void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        gameObject.transform.Rotate(0, Time.deltaTime * -30, 0);
    }
}
