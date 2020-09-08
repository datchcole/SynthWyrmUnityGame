using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollidingNotifyDoll : MonoBehaviour {
	public bool playerDollTriggerStanding;
	public int dollTalkTrigger;

	void Update(){
		if(dollTalkTrigger == 1){
			playerDollTriggerStanding = true;
		}else{
			playerDollTriggerStanding = false;
			//add delay
			
			
		}
	
	}

	
	void OnTriggerEnter(){
		dollTalkTrigger = 1;
	}

	void OnTriggerExit(){
		dollTalkTrigger = 0;
	}
}
