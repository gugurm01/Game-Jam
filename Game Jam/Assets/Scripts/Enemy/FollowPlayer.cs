using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(Player.instance.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CostasPlayer"))
        {
            PlayerLife.instance.TakeDamage(1);
        }
    }
}
