using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunAround : MonoBehaviour {

    public int xMin;
    public int xMax;
    public int zMin;
    public int zMax;

    private NavMeshAgent agent;

    private bool hasLanded = false;
    private Rigidbody rb;
    private bool running = false;

    private System.Random rand;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        rand = new System.Random();
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasLanded)
        {
            Debug.Log(rb.velocity.ToString());
            if (rb.velocity == Vector3.zero)
            {
                running = true;
            }
        }
        if(running)
        {
            agent.enabled = true;
            // Check if we've reached the destination
            if (!agent.pathPending)
            {
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        float randX = rand.Next(xMin, xMax);
                        float randZ = rand.Next(zMin, zMax);

                        agent.SetDestination(new Vector3(randX, 2, randZ));
                    }
                }
            }
            
        }
	}
}
