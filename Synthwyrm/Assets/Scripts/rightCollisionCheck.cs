using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightCollisionCheck : MonoBehaviour {

	public bool rightTrigger;
	public bool hasCollidedRight;
	// Update is called once per frame
	void Update () {
		if(rightTrigger == true){
			hasCollidedRight = true;
		}else{
			hasCollidedRight = false;
		}
	}
	
	void OnTriggerEnter(){
		rightTrigger = true;
	}

	void OnTriggerExit(){
		rightTrigger = false;
	}
}
