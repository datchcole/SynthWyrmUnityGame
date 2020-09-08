using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordSwing : MonoBehaviour {

	public GameObject sword;
	public int status;
	//private Animator anim;
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			sword.GetComponent<Animator>().Play("swordVertAnim");
		}
	}
	
	
	/*IEnumerator SwingSword(){
		status = 1;
		sword.GetComponent<Animator>().Play("swordVertAnim");
		status = 2;
		yield return new WaitForSeconds(0.5f);
		status = 0;
		
	}*/
}
