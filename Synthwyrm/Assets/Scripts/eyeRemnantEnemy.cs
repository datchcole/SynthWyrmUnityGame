using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeRemnantEnemy : MonoBehaviour {

	
		public int enemyHealth = 20;
		public GameObject remEnemy;
		public int remStatus = 0;
		public bool enemyDead = false;
	
	void DeductPoints(int damageAmount){
			enemyHealth -= damageAmount;
		
	
	}
	// Update is called once per frame
	void Update () {
		//remEnemy.SetBool("isDead", false);
		if(enemyHealth <= 0){
			//remEnemy.GetComponent<Animator>().SetBool("isDead", true);
			//remEnemy.GetComponent<Animator>().Play("synthServantDeath");
			//remEnemy.GetComponent<Animator>().enabled = false;
				//Destroy(gameObject);
				//enemyHealth+=1;
			enemyDead = true;
				
				
					
		}
		else{
			remEnemy.GetComponent<Animator>().SetBool("isDead", false);
		}
	}
}
