using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toothpickAI : MonoBehaviour {
	//put script on button object
	
	public GameObject toothPick;
	public bool hasPlayerTriggered;

	//private DialogueSystem dialogueSystem;

	[TextArea(5,10)]
	public string[] sentences;
	

	void Start(){
		//dialogueSystem = FindObjectOfType<DialogueSystem>();

	}
	// Update is called once per frame
	void Update () {
		
		/**hasPlayerTriggered = GameObject.Find("talkToToothTriggerCube").GetComponent<boxCollidingNotifyTooth>().playerToothTriggerStanding;
		
		if(hasPlayerTriggered == true){
			toothPick.GetComponent<Animator>().SetBool("firstSeenPlayer", true);
		}else{
			toothPick.GetComponent<Animator>().SetBool("firstSeenPlayer", false);
			//add delay
			
			
		}**/
		////////////////////////////////////////////////////////
		

	}
	/*
	public void OnTriggerStay(Collider other){
		this.gameObject.GetComponent<NPC>().enabled = true;
		FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
		if((other.gameObject.tag == "player") && Input.GetKeyDown(KeyCode,F)){

			//this.gameObject.GetComponent<NPC>().enabled = true;
			//dialogueSystem.dialogueLines = sentences;
		}

		//dialogueSystem.dialogueLines = sentences;
		
	}

	public void OnTriggerExit(){

		FindObjectOfType<DialogueSystem>().OutOfRange():
		this.gameObject.GetComponent<NPC>().enabled = false;

	}
*/

	


}
