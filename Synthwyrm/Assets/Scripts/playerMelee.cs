﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMelee : MonoBehaviour {

	public int damageDealt = 10;
	public float targetDistance;
	public float allowedRange = 2.8f;
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			RaycastHit hit;
			if(Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)){
				targetDistance = hit.distance;
				if(targetDistance <= allowedRange) {
					hit.transform.SendMessage("DeductPoints", damageDealt, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
