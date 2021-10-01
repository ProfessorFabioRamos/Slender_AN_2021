using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform playerTransform;
    private NavMeshAgent agent;
    public GameObject explosionObject;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTransform.position);
    }

    void OnDestroy()
    {
        Instantiate(explosionObject, transform.position, Quaternion.identity);
    }
}
