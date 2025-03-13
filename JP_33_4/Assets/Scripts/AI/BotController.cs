using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float detectDistance = 10f;
    public float stopDistance = 2f;


    private bool isDtected;

    void Update()
    {

        CheckDistance();

        if (isDtected)
        {
            Move();
        }
    }

    private void CheckDistance()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < detectDistance && distance > stopDistance)
        {
            isDtected = true;
        }
        else
        {
            isDtected = false;
        }
    }

    private void Move()
    {
        agent.SetDestination(player.position);
    }
}
