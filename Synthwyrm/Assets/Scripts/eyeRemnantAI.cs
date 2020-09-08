using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeRemnantAI : MonoBehaviour {

	private bool isWandering = false;
	private bool isRotatingLeft = false;
	private bool isRotatingRight = false;
	private bool isWalking = false;

	public float moveSpeed = 5f;
	public float rotSpeed = 100f;	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isWandering==false){
				StartCoroutine(Wander());
		}
	}
	
	IEnumerator Wander(){
		int rotTime = Random.Range(1,3);
		int rotateWait = Random.Range(1,4);
		int rotateLorR = Random.Range(1,2);
		yield return new WaitForSeconds(rotTime);
	}
}
