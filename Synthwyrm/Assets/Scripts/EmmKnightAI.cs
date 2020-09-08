using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmmKnightAI : MonoBehaviour {
	
	//public bool isAttacking = false;
	public float targetDistance;
	public float allowedRange = 12;
	public GameObject enemy;
	public float enemySpeed;
	//public int attackTrigger;
	public RaycastHit shot;
	
	public GameObject player;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		//Vector3 vect = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
		
		
		//if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot)){
			targetDistance = Vector3.Distance(enemy.transform.position, player.transform.position);
			if(targetDistance <= allowedRange && targetDistance >= 4 ){
				Vector3 targetPos = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
				transform.LookAt(targetPos);
				enemySpeed = 0.04f;
				//if(attackTrigger == 0){
					//enemy.GetComponent<Animator>().SetBool("isAttacking" ,false);
					enemy.GetComponent<Animator>().SetBool("isWalking", true);
					enemy.GetComponent<Animator>().SetBool("isIdle", false);
					
					//enemy.GetComponent<Animator>().Play("synthServantWalk");
					transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z), enemySpeed);
				//}
				
				
			}
			else{
				enemySpeed = 0;
				//enemy.GetComponent<Animator>().SetBool("isAttacking" , false);
				enemy.GetComponent<Animator>().SetBool("isWalking", false);
				enemy.GetComponent<Animator>().SetBool("isIdle", true);
				//enemy.GetComponent<Animator>().Play("synthServantIdle");
			}
			
			
			
			
		

		
	}
	
	void OnTriggerEnter(Collider other){
		//if player reaches his trigger, he will resume walking
		//if(other.gameObject == player ){
 
		
	}
	
	void OnTriggerExit(Collider other){

		
	}
	
	
	
	

}
