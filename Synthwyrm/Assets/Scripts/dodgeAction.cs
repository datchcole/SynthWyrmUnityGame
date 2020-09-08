using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class dodgeAction : MonoBehaviour {

	public GameObject player;
	public Camera playerCam2;
	
	public bool isColliding = false;
	public bool onCooldown = false;
	//public PostProcessingProfile postProf;

	Vector3 leftVector;
	// Use this for initialization
	void Start () {
		//var blur:MotionBlur= playerCam2.GetComponent(MotionBlur);
		
	}
	
	// Update is called once per frame
	void Update () {
		onCooldown = false;
		//GetComponent<UnityStandardAssets.ImageEffects.MotionBlur>().enabled = false;
		
		//camForwardPos = playerCam2.transform.forward;
		//Vector3 translation = camForwardPos;

		//Vector3 oveDir = 
		//playerCam2.transform.forward += this.transform.forward;
		if(Input.GetKeyDown(KeyCode.Q)){
			Debug.Log("Left Dodge");
			Vector3 leftVector = new Vector3(playerCam2.transform.position.x -1 ,playerCam2.transform.position.y,playerCam2.transform.position.z);

			float x = Input.GetAxis("Horizontal");
			float z = Input.GetAxis("Vertical");

			//Vector3 leftVector = (transform.right * x + transform.forward * z);
			if(isColliding == false){
				
				player.transform.Translate(Vector3.left * 100.0f * Time.deltaTime);
			}
			dodgeDelay();
		}

		if(Input.GetKeyDown(KeyCode.E)){
			Vector3 rightVector = new Vector3(playerCam2.transform.position.x +1 ,playerCam2.transform.position.y,playerCam2.transform.position.z);
			if(isColliding == false){
				Debug.Log("Right Dodge");
				player.transform.Translate(Vector3.right * 100.0f * Time.deltaTime);
			}
			dodgeDelay();
		}
	}

	void OnCollisionEnter(Collision collision){   ///check for if tag != terrain
		
		if(collision.gameObject.tag != "terrain"){
			isColliding = true;

		}
	}

	void OnCollisionExit(Collision collision){

		if(collision.gameObject.tag != "terrain"){
			isColliding = false;
		}
	
	}

	IEnumerator dodgeDelay(){
		Debug.Log("Delay Start");
		//GetComponent<UnityStandardAssets.ImageEffects.MotionBlur>().enabled = true;
		onCooldown = true;
		Debug.Log("Delay End");	
		yield return new WaitForSeconds(5.0f);
	}
}


