using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenufunction : MonoBehaviour {

	// Use this for initialization
	void Update(){
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(1);
		}
	}

}
