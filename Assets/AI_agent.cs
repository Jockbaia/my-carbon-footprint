using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class AI_agent : MonoBehaviour
{

    public NavMeshAgent agent;

    [Range(0, 100)] public float speed;
    [Range(1, 500)] public float walkRadius;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(agent != null){

            agent.speed = speed;
            agent.SetDestination(RandomLocation());
        }
    }

    public Vector3 RandomLocation(){

        Vector3 finalPos = Vector3.zero;
        Vector3 randomPos = Random.insideUnitSphere * walkRadius;
        randomPos += transform.position;
        if(NavMesh.SamplePosition(randomPos, out NavMeshHit hit, walkRadius, 1)){

            finalPos = hit.position;
        }
        return finalPos;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (agent != null && agent.remainingDistance <= agent.stoppingDistance){

            agent.SetDestination(RandomLocation());
        }
    }
}
