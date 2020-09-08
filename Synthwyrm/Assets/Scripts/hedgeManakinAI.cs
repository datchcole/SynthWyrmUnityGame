using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedgeManakinAI : MonoBehaviour {
	
	public  GameObject hedgeManakin;
	public GameObject playerChar;
	public float distance;
	public bool isVisible;
	public Renderer rend;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rend = GetComponent<Renderer>();
		distance = Vector3.Distance(hedgeManakin.transform.position, playerChar.transform.position);
		//if(renderer.isVisible()
			

		if(distance <= 5 && rend.isVisible==false){   //player is close and turned away
			hedgeManakin.transform.LookAt(playerChar.transform.position);
		}
		
	}
}
