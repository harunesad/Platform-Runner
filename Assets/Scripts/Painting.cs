using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public static Painting instance = null;
    public GameObject brush;
    void Update()
    {
        Paint();
    }
    void Paint()
    {
        if (SwerveMove.instance.wall.activeInHierarchy)
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    var go = Instantiate(brush, new Vector3(hit.point.x, hit.point.y, brush.transform.position.z), brush.transform.rotation);
                    go.transform.parent = transform;
                    go.transform.localScale = Vector3.one * 0.1f;
                    if (!hit.transform.CompareTag("Paint"))
                    {
                        Destroy(go.gameObject);
                    }
                }

            }
        }
    }
}
