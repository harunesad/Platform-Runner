using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public static Trigger instance = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -21);
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            SwerveMove.instance.finish = true;
            if (gameObject.name.Equals("Player"))
            {
                print("s");
                SwerveMove.instance.wall.gameObject.SetActive(true);
            }
            for (int i = 0; i < SwerveMove.instance.rb.Count; i++)
            {
                SwerveMove.instance.rb[i].constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.parent = null;
            if (gameObject.name.Equals("Player"))
            {
                transform.rotation = Quaternion.identity;
            }
        }
    }
}
