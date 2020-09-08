using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollidingNotifyTooth : MonoBehaviour {
	public bool playerToothTriggerStanding;
	public int toothTalkTrigger;

	
	// Update is called once per frame
	void Update () {
		if(toothTalkTrigger == 1){
			playerToothTriggerStanding = true;
		}else{
			playerToothTriggerStanding = false;
			//add delay
			
			
		}
	}
	

	
	void OnTriggerEnter(){
		toothTalkTrigger = 1;
	}

	void OnTriggerExit(){
		toothTalkTrigger = 0;
	}
}
