using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceStick : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.name.Equals("Player"))
            {
                Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
                rigidbody.AddExplosionForce(300, Vector3.ClampMagnitude(Vector3.back, 25), 50);
            }
            else
            {
                collision.gameObject.transform.Translate(Vector3.back * Time.deltaTime * 10);
            }
        }
    }
}
