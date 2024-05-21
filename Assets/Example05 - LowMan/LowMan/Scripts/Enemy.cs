using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
	public GameObject player;
	public NavMeshAgent agent;
	
	// Update is called once per frame
	void Update () 
	{
			agent.SetDestination(player.transform.position);
		if(Vector3.Distance(player.transform.position, transform.position)<5)
	{
		print("Killed");
	}
	}
}