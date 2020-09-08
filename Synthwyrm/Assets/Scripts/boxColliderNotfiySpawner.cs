using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxColliderNotfiySpawner : MonoBehaviour {
	public bool playerDSpawnTrigger;
	public int spawnTrigger;

	void Update(){
		if(spawnTrigger == 1){
			playerDSpawnTrigger = true;
		}else{
			playerDSpawnTrigger = false;
			//add delay
			
			
		}
	
	}

	
	void OnTriggerEnter(){
		spawnTrigger = 1;
	}

	void OnTriggerExit(){
		spawnTrigger = 0;
	}
}
