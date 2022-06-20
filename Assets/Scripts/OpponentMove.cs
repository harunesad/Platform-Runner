using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpponentMove : MonoBehaviour
{
    public static OpponentMove instance = null;
    public Transform target;

    private NavMeshAgent agent;
    private Animator opponentAnim;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        agent = GetComponent<NavMeshAgent>();
        opponentAnim = GetComponent<Animator>();
    }
    void Update()
    {
        OpponnetMoving();
    }
    void OpponnetMoving()
    {
        if (SwerveMove.instance.start && !SwerveMove.instance.finish)
        {
            agent.SetDestination(new Vector3(transform.position.x, transform.position.y, target.transform.position.z));
            opponentAnim.SetFloat("Start", 2);
        }
        if (SwerveMove.instance.finish)
        {
            opponentAnim.SetFloat("Start", 1);
            agent.Stop(true);
        }
    }
}
