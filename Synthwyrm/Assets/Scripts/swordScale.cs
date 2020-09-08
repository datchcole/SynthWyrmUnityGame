using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordScale : MonoBehaviour {
	
	public GameObject swordSelf;
	public Vector3 scaleChange;
	// Use this for initialization
	void Start () {
		scaleChange =  new Vector3(0.5f,0.5f,0.5f);
		swordSelf.transform.localScale=  -scaleChange;
	}
	

}
