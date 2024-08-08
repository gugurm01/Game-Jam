using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform costasDoPlayer;
    public GameObject meshRenderer;

    [SerializeField] GameObject play;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
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
        meshRenderer.SetActive(true);
        yield return new WaitForSeconds(1);
        meshRenderer.SetActive(false);
    }
}
