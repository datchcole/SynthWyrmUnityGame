using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBossAI : MonoBehaviour {

	// Use this for initialization
	public GameObject boss;
	public GameObject leftBox;
	public GameObject rightBox;
	//public GameObject trap;
	
	public bool leftCollided;
	public bool rightCollided;
	public int bossTrigger;
	public int swipeCount;
	
	// Update is called once per frame
	void Update () {
		if(bossTrigger == 1){
			//player has entered boss area. Disable idle, start sequence of boss aproach -> boss waiting for attack
			boss.GetComponent<Animator>().SetBool("idleBoss", false);
			boss.GetComponent<Animator>().SetBool("lookBossSequence", true);
			boss.GetComponent<Animator>().SetBool("rightSwipe",false);
			boss.GetComponent<Animator>().SetBool("leftSwipe",false);
			
			//StartCoroutine(delayer());
		//}else{
			//boss.GetComponent<Animator>().SetBool("idleBoss", true);
			//boss.GetComponent<Animator>().SetBool("lookBossSequence", false);
			
			//add delay
			//trap.GetComponent<Animator>().SetBool("activated", false);
			//.../////playerDistance2 = GameObject.Find("eyeInsider").GetComponent<eyeFollowPlayer>().playerDistance;////..../////
			leftCollided = GameObject.Find("bossLeftCollider").GetComponent<leftCollisionCheck>().hasCollidedLeft;
			rightCollided = GameObject.Find("bossRightCollider").GetComponent<rightCollisionCheck>().hasCollidedRight;
			
			
			//----------add condition if player ttacks start boss attack phase////------//
			
			
			if(leftCollided == true  && swipeCount < 3 ){    // player is on left side and boss hasnt attacked 3 times yet, so he can attack again
					boss.GetComponent<Animator>().SetBool("lookBossSequence", false);
					boss.GetComponent<Animator>().SetBool("leftSwipe",true);
					swipeCount++;
					
					
			}
			
			if(rightCollided == true && swipeCount < 3){
					boss.GetComponent<Animator>().SetBool("lookBossSequence", false);
					boss.GetComponent<Animator>().SetBool("rightSwipe",true);
					swipeCount++;
					
			}
			
			if(swipeCount >= 3){   //max sqipes reached. Trigger Boss looking at player, leaving them vulnerable
				attackDelay();
			
			}
			
		}
		
		
		//
	}
	/*
	IEnumerator delayer(){
		button.GetComponent<Animator>().SetBool("pressed", true);
		//add delay
		yield return new WaitForSeconds(0.2f);
		//trap.GetComponent<Animator>().SetBool("activated", true);
	
	}

*/
	void OnTriggerEnter(){
		bossTrigger = 1;
	}

	void OnTriggerExit(){
		bossTrigger = 0;
	}
	IEnumerator attackDelay(){
		
					boss.GetComponent<Animator>().SetBool("leftSwipe",false);
				boss.GetComponent<Animator>().SetBool("rightSwipe", false);
				
				//set idle to delay maybe in transistion to give player time to attack//
					boss.GetComponent<Animator>().SetBool("lookBossSequence", true);
					swipeCount = 0;	
		yield return new WaitForSeconds(2.0f);
	}
	
}