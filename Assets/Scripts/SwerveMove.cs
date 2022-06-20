using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMove : MonoBehaviour
{
    public static SwerveMove instance = null;
    public List<Rigidbody> rb;

    float swerveSpeed = 0.4f;

    public GameObject player, wall;
    public Animator playeranim;

    public bool start, finish;
    private void Awake()
    {
        start = false;
        finish = false;
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = true;
        }
        if (start && !finish)
        {
            HorizontalMove();
            Forward();
            Limit();
        }
        if (finish)
        {
            playeranim.SetFloat("Start", 1);
        }
    }
    public void HorizontalMove()
    {
        float swerveAmount = Time.deltaTime * swerveSpeed * SwerveSystem.instance.moveFactorX;
        player.transform.Translate(x: swerveAmount, y: 0, z: 0);
    }
    void Forward()
    {
        playeranim.SetFloat("Start", 2);
        player.transform.Translate(Vector3.forward * Time.deltaTime * 1.5f);
    }
    void Limit()
    {
        float posX = Mathf.Clamp(player.transform.position.x, -0.9f, 0.9f);
        player.transform.position = new Vector3(posX, player.transform.position.y, player.transform.position.z);
    }
}
