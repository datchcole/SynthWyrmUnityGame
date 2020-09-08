using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionBoss : MonoBehaviour {

	// Use this for initialization
	public int i = 0;
	
	void OnTriggerEnter(){
		if(this.enabled){
			SceneManager.LoadScene("testerObjects", LoadSceneMode.Single);
			Debug.Log("Loading Scene: " + i);
			i++;
		}
		this.enabled = false;
	}

	void OnTriggerExit(){
		
	}
}