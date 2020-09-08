using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedgeAttack : MonoBehaviour {
	
	public GameObject player;
	public GameObject hedgeEnemy;
	public int attackTriggerHedge;
	
	// Update is called once per frame
	void Update () {
		
		if(attackTriggerHedge == 1){
			hedgeEnemy.GetComponent<Animator>().SetBool("isAttacking", true);
		}else{
			hedgeEnemy.GetComponent<Animator>().SetBool("isAttacking", false);
		}
			
	}

	void OnTriggerEnter(){
		attackTriggerHedge = 1;
	}
	
	void OnTriggerExit(){
		attackTriggerHedge = 0;
	}	
	
}

