using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class synthAI : MonoBehaviour {
	
	//public bool isAttacking = false;
	public float targetDistance;
	public float allowedRange = 10;
	public GameObject enemy;
	public float enemySpeed;
	public int attackTrigger;
	public RaycastHit shot;
	public bool isDead = false;
	
	public GameObject player;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		//Vector3 vect = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
		
		
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot)){
			targetDistance = shot.distance;
			if(targetDistance <= allowedRange && isDead == false /*&& targetDistance >= 2*/ ){
				transform.LookAt(player.transform.position);
				enemySpeed = 0.04f;
				if(attackTrigger == 0){
					enemy.GetComponent<Animator>().SetBool("isAttacking" ,false);
					enemy.GetComponent<Animator>().SetBool("isWalking", true);
					enemy.GetComponent<Animator>().SetBool("isIdle", false);
					
					//enemy.GetComponent<Animator>().Play("synthServantWalk");
					transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z), enemySpeed);
				}
				
				
			}
			else{
				enemySpeed = 0;
				enemy.GetComponent<Animator>().SetBool("isAttacking" , false);
				enemy.GetComponent<Animator>().SetBool("isWalking", false);
				enemy.GetComponent<Animator>().SetBool("isIdle", true);
				//enemy.GetComponent<Animator>().Play("synthServantIdle");
			}
			
			
		}
		if(attackTrigger ==1){
			transform.LookAt(player.transform.position);
				Debug.Log("Reached Loop");
				enemySpeed = 0;
				enemy.GetComponent<Animator>().SetBool("isWalking", false);
				enemy.GetComponent<Animator>().SetBool("isIdle", false);
				enemy.GetComponent<Animator>().SetBool("isAttacking" ,true);
		}
		if(enemy.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("synthServantDeath")){
			isDead = true;
		}
		
	}
	
	void OnTriggerEnter(){
		attackTrigger = 1;
	}
	
	void OnTriggerExit(){
		attackTrigger = 0;
	}
}
