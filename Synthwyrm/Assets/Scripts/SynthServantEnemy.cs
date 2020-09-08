using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynthServantEnemy : MonoBehaviour {

	
		public int enemyHealth = 50;
		public GameObject synthEnemy;
		public int synthStatus = 0;
		public bool isDead = false;
	
	void DeductPoints(int damageAmount){
			enemyHealth -= damageAmount;
		
	
	}
	// Update is called once per frame
	void Update () {
		//synthEnemy.SetBool("isDead", false);
		if(enemyHealth <= 0){
			synthEnemy.GetComponent<Animator>().SetBool("isDead", true);
			isDead = true;
			//synthEnemy.GetComponent<Animator>().Play("synthServantDeath");
			//synthEnemy.GetComponent<Animator>().enabled = false;
				//Destroy(gameObject);
				//enemyHealth+=1;
					
		}
		else{
			synthEnemy.GetComponent<Animator>().SetBool("isDead", false);
		}
	}
}
