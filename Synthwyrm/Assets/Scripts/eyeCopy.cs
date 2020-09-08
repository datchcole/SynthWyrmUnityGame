using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class eyeCopy : MonoBehaviour {
	
	public RaycastHit scan;
	public GameObject player;
	public float range = 9;
	public float playerDistance2;
	public GameObject eyeInside2;
	//public GameObject copyEye;
///////attach to inner eye object!!!//
	
	// Update is called once per frame
	void Update () {
		playerDistance2 = GameObject.Find("eyeInsider").GetComponent<eyeFollowPlayer>().playerDistance;
		//playerDistance2 = copyEye.GetComponent<playerDistance>();
		
		//if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out scan)){
			//playerDistance = scan.distance;
			if(playerDistance2 <= range  ){
				eyeInside2.GetComponent<Animator>().SetBool("inRange" , true);
				eyeInside2.GetComponent<Animator>().applyRootMotion = true;
				transform.LookAt(player.transform.position);		
			}else{
				eyeInside2.GetComponent<Animator>().applyRootMotion = false;
				eyeInside2.GetComponent<Animator>().SetBool("inRange" , false);	
			}
		
		/*}*/
	}
}
