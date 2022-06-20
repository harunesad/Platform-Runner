using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    public GameObject movingStick;
    void Start()
    {
        InvokeRepeating("LeftStick", 0, 1);
    }
    void LeftStick()
    {
        movingStick.transform.localPosition = new Vector3(-0.125f, movingStick.transform.localPosition.y, movingStick.transform.localPosition.z);
        StartCoroutine(RightStick());
    }
    IEnumerator RightStick()
    {
        yield return new WaitForSeconds(0.5f);
        movingStick.transform.localPosition = new Vector3(0.16f, movingStick.transform.localPosition.y, movingStick.transform.localPosition.z);
    }
}
