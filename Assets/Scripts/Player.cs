using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshAgentÇåƒÇ—èoÇ∑ÇÃÇ…ïKóvÇ»Import
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            navMeshAgent.nextPosition += Vector3.forward * Time.deltaTime;
            transform.LookAt(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            navMeshAgent.nextPosition -= Vector3.right * Time.deltaTime;
            transform.LookAt(-Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            navMeshAgent.nextPosition -= Vector3.forward * Time.deltaTime;
            transform.LookAt(-Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            navMeshAgent.nextPosition += Vector3.right * Time.deltaTime;
            transform.LookAt(Vector3.right);
        }
    }
}
