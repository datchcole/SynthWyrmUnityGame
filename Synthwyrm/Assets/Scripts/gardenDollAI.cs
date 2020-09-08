using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gardenDollAI : MonoBehaviour {
	
	public bool playerTriggeredDoll;
	public GameObject gardenerDoll;
	
	// Update is called once per frame
	void Update () {
		playerTriggeredDoll = GameObject.Find("talkToDollTriggerCube").GetComponent<boxCollidingNotifyDoll>().playerDollTriggerStanding;
		
		if(playerTriggeredDoll == true){
			gardenerDoll.GetComponent<Animator>().SetBool("isTriggerGarden", true);
			gardenerDoll.GetComponent<Animator>().SetBool("isIdleDoll", false);
		}else{
			gardenerDoll.GetComponent<Animator>().SetBool("isTriggerGarden", false);
			gardenerDoll.GetComponent<Animator>().SetBool("isIdleDoll", true);
			gardenerDoll.GetComponent<Animator>().SetBool("isTriggerGarden", false);
			//add delay
			
			
		}
	}
}
