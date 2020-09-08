using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftCollisionCheck : MonoBehaviour {

	public bool leftTrigger;
	public bool hasCollidedLeft;
	// Update is called once per frame
	void Update () {
		if(leftTrigger == true){
			hasCollidedLeft = true;
		}else{
			hasCollidedLeft = false;
		}
	}
	
	void OnTriggerEnter(){
		leftTrigger = true;
	}

	void OnTriggerExit(){
		leftTrigger = false;
	}
}
