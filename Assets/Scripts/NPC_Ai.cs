using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Ai : MonoBehaviour
{
    [Header("Components")]
    public List<Transform> wayPoints;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    private Animator anim;
    public LayerMask playerLayer;

    [Header("Variables")]
    public int currentWaypointIndex = 0;
    public float speed = 2f;
    private bool isPlayerDetected = false;
    private bool onRadious;
    
    
    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        navMeshAgent.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlayerDetected) {
            Walking();
        }
        else
        {
            StopWalking();
            anim.SetTrigger("Attack");
        }
    }

    public void Walking()
    {
        if(wayPoints.Count== 0)
        {
            return;
        }

        float distanceToWayPoint = Vector3.Distance(wayPoints[currentWaypointIndex].position,
            transform.position);

        if(distanceToWayPoint <= 2)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % wayPoints.Count;
        }

        navMeshAgent.SetDestination(wayPoints[currentWaypointIndex].position);
        anim.SetBool("Move", true);
        onRadious = false;
    }

    public void StopWalking()
    {
        navMeshAgent.isStopped = true;
        anim.SetBool("Move", false);
        onRadious = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerDetected = false;
        }
    }
}
