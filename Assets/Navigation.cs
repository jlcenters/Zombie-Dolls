using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float updateDelay = 0.3f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        InvokeRepeating("FollowPlayer", 0.5f, updateDelay);
    }

    void FollowPlayer()
    {

        agent.SetDestination(target.position);
    }
}
