using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcTooth : MonoBehaviour {

	public float theDistance;
	public GameObject player;
	public GameObject textBox;
	public GameObject actionText;
	public GameObject actionDisplay;
	public GameObject NPCText;
	public GameObject npc;
	public Camera npcCam;
	public bool isTalking = false;
	public Camera playerCam;
	//private bool isTalking = false;
	//private bool isIdle = true;


	private Queue<string> sentences;

	void Start(){

	}
		
	void Update(){
		//theDistance = new Vector3.....
		theDistance = Vector3.Distance(npc.transform.position, player.transform.position);
		if(isTalking == false){	
			npc.GetComponent<Animator>().SetBool("isTalking", false);
			npc.GetComponent<Animator>().SetBool("isIdle", true);

			playerCam.enabled = true;
			npcCam.enabled = false;
		}

	}

	void OnMouseOver(){

		Debug.Log("Entered Mouse Over");
		if(theDistance <=8){
			actionText.GetComponent<Text>().text = "[F] Talk";
			actionDisplay.SetActive(true);
			if(isTalking == false){
				actionText.SetActive(true);
			}

		}

		if(Input.GetKeyDown(KeyCode.F)){    //change to getbuttondown F ???
			Debug.Log("F key pressed");
			if(theDistance <= 8){
				Screen.lockCursor = false;
				Cursor.visible = true;
				actionDisplay.SetActive(false);
				actionText.SetActive(false);
				StartCoroutine(NPCToothActive());

			}

		}
	}

	void OnMouseExit(){
		actionDisplay.SetActive(false);
		actionText.SetActive(false);

	}
	///////CREATE SECONDARY CAMERA THAT FACES TOOTHPICK. ENABLE TOOTHCAMERA AND DISABLE PLAYER CAMERA WHEN TALKING TO NPC [INITIATED INPUT]//////////
	IEnumerator NPCToothActive(){
		actionText.SetActive(false);
		textBox.SetActive(true);
		actionText.SetActive(false);
		NPCText.GetComponent<Text>().text = "Test TEXT: Dialogue text box 1 is put here and is the first in a sequence";
		NPCText.SetActive(true);
		///enable npc cam, disable layer temporarily
		isTalking = true;
		npcCam.enabled = true;
		playerCam.enabled = false;
			npc.GetComponent<Animator>().SetBool("isTalking", true);
			npc.GetComponent<Animator>().SetBool("isIdle", false);
		//npcCam.enabled = true;

		yield return new WaitForSeconds(4.0f);
		NPCText.GetComponent<Text>().text = "Second sequence line is here";
		yield return new WaitForSeconds(4.0f);
		isTalking = false;
		NPCText.SetActive(false);
		textBox.SetActive(false);
		
		
	}


}
