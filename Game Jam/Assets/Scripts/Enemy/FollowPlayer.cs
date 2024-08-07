using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform costasDoPlayer;
    MeshRenderer meshRenderer;

    [SerializeField] GameObject play;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        agent.SetDestination(costasDoPlayer.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CostasPlayer"))
        {
            play.GetComponent<PlayerLife>().TakeDamage(1);
            StartCoroutine(Aparecer());
        }
    }

    IEnumerator Aparecer()
    {
        meshRenderer.enabled = true;
        yield return new WaitForSeconds(1);
        meshRenderer.enabled = false;
    }
}
