using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class eyeFollowPlayer : MonoBehaviour {
	
	public RaycastHit scan;
	public GameObject player;
	public float range = 9;
	public float playerDistance;
	public GameObject eyeInside;
///////attach to inner eye object!!!//
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out scan)){
			playerDistance = scan.distance;
			if(playerDistance <= range  ){
				eyeInside.GetComponent<Animator>().SetBool("inRange" , true);
				eyeInside.GetComponent<Animator>().applyRootMotion = true;
				transform.LookAt(player.transform.position);		
			}else{
				eyeInside.GetComponent<Animator>().applyRootMotion = false;
				eyeInside.GetComponent<Animator>().SetBool("inRange" , false);	
			}
		
		}
	}
	
	
	

}
