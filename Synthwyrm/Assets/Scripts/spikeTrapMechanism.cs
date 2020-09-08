using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrapMechanism : MonoBehaviour {
	//put script on button object
	public GameObject button;
	public GameObject trap;
	public int trapTrigger;
	
	// Update is called once per frame
	void Update () {
		
		if(trapTrigger == 1){
			StartCoroutine(delayer());
		}else{
			button.GetComponent<Animator>().SetBool("pressed", false);
			//add delay
			trap.GetComponent<Animator>().SetBool("activated", false);
			
		}
	}
	
	IEnumerator delayer(){
		button.GetComponent<Animator>().SetBool("pressed", true);
		//add delay
		yield return new WaitForSeconds(0.2f);
		trap.GetComponent<Animator>().SetBool("activated", true);
	}
	
	void OnTriggerEnter(){
		trapTrigger = 1;
	}

	void OnTriggerExit(){
		trapTrigger = 0;
	}
}
