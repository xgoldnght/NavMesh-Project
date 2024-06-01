using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[RequireComponent (typeof (NavMeshAgent))]
public class UnityKill : MonoBehaviour 
{

    public Transform myPlayer;

    void Update () 
    {
	    transform.LookAt (myPlayer.position);
	    if (Vector3.Distance (myPlayer.transform.position, transform.position) >= 30) {
	        GetComponent <NavMeshAgent> ().enabled = false;
	    }

	    if (Vector3.Distance (myPlayer.transform.position, transform.position) <= 30) {
	        GetComponent <NavMeshAgent> ().enabled = true;
	        GetComponent <NavMeshAgent> ().destination = myPlayer.transform.position;
	    }

		if (Vector3.Distance (myPlayer.transform.position, transform.position) <= 1.4f) {
	        GetComponent <NavMeshAgent> ().enabled = false;
	    }
    }
}