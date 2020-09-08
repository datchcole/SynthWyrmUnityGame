using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeRemnantAI1 : MonoBehaviour {

	public bool isAttacking = false;
	public float targetDistance;
	public float allowedRange = 14;
	public GameObject enemy;
	public float enemySpeed;
	public int attackTrigger;
	public bool hasSeen = false;
	public RaycastHit shot;
	public bool isAlive = true;
	public ParticleSystem waterPart;
	public GameObject remCube1;
	public Rigidbody rb;
	public bool hasCollided = false;
	
	public int remEnemyHealth = 10;
	
	
	public GameObject player;
	// Use this for initialization
	
	void DeductPoints(int damageAmount){
			remEnemyHealth -= damageAmount;
	}
	
	void Start(){

		waterPart.Play();
		rb = GetComponent<Rigidbody>();
	}

	/*void deductHealth(int damageAmount){
		remEnemyHealth -= damageAmount;
	}
	*/
	// Update is called once per frame
	void Update () {
		
		float totalDur = waterPart.duration + waterPart.startLifetime;
		Destroy(waterPart, totalDur);
		//Vector3 vect = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
		////get death status////
		
		//var aliveScript = remCube1.GetComponent("eyeRemnantEnemy");
		
		//GameObject parentEnemy = GameObject.Find("remCube")
		///////////////PlayerScript scripter = this.GetComponent<
		
		//if(aliveScript.enemyDead == true){
		//		isAlive = false;
	//	}
		
		
		///////////
		float timeVar =  (Time.deltaTime * 150.0f);
		//if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot)){
			targetDistance = Vector3.Distance(enemy.transform.position, player.transform.position);
			
			
			if(targetDistance > allowedRange){
				
				hasSeen = false;
				
			}
			
			
			if(targetDistance <= allowedRange && targetDistance >= 1 && remEnemyHealth>0 && hasSeen == false && isAlive == true){   ///do initial quaternion
					Vector3 targetPos = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
				//transform.LookAt(targetPos);
							
							Quaternion rot = Quaternion.LookRotation(targetPos);
							//rot.y = 0;
							//rot *= Quaternion.Euler(90f, 0f,0f);
				transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, timeVar);
				if(Quaternion.Angle(transform.rotation, rot)<=0.01f){
					hasSeen = true;
				}
			}

			if(targetDistance <= allowedRange && targetDistance >= 1 && remEnemyHealth>0 && hasSeen == true && isAlive == true){  //has been seen before
				Vector3 targetPos = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
				//transform.LookAt(targetPos);
							
							//Quaternion rot = Quaternion.LookRotation(targetPos);
							//rot.y = 0;
							//rot *= Quaternion.Euler(90f, 0f,0f);
				//transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, timeVar);
				enemySpeed = 0.075f;
				if(attackTrigger == 0 && isAlive == true && remEnemyHealth > 0 && hasCollided == false){
					//enemy.GetComponent<Animator>().SetBool("isAttacking" ,false);
					enemy.GetComponent<Animator>().SetBool("isWalking", true);
					//enemy.GetComponent<Animator>().SetBool("isIdle", false);
					enemy.GetComponent<Animator>().SetBool("isAttacking" , false);
					targetPos = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
				//transform.LookAt(targetPos);
							//rot = Quaternion.LookRotation(targetPos);
							//rot.y = 0;
				//transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, timeVar);
					
					//enemy.GetComponent<Animator>().Play("synthServantWalk");
					//targetPos = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
				//transform.LookAt(targetPos);
							//rot = Quaternion.LookRotation(targetPos);
							
					//if(){		//check if object in front
					
						transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z), enemySpeed);
					
					
					
					
					
					//}else{
						//transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.5f, transform.position.y, player.transform.position.z), enemySpeed);
				}
				enemy.transform.LookAt(targetPos);
				
			}
			else{
				enemySpeed = 0;
				//enemy.GetComponent<Animator>().SetBool("isAttacking" , false);
				enemy.GetComponent<Animator>().SetBool("isWalking", false);
				//enemy.GetComponent<Animator>().SetBool("isIdle", true);
				enemy.GetComponent<Animator>().SetBool("isAttacking" ,false);
				//enemy.GetComponent<Animator>().Play("synthServantIdle");
			}
		
		if(attackTrigger ==1 && remEnemyHealth >0){
			//Vector3 targetPos = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
			//transform.LookAt(targetPos);
			//float timeVar = 2.0f + (Time.deltaTime * 2.0f);
			//Quaternion rot = Quaternion.LookRotation(targetPos);
			//transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, timeVar);
				Debug.Log("Reached Loop");
				enemySpeed = 0;
				enemy.GetComponent<Animator>().SetBool("isWalking", false);
				//enemy.GetComponent<Animator>().SetBool("isIdle", false);
				enemy.GetComponent<Animator>().SetBool("isAttacking" ,true);
		}	

		if(remEnemyHealth <=0){
			enemy.GetComponent<Animator>().SetBool("isDead", true);
			enemy.GetComponent<Animator>().SetBool("isWalking", false);
				//enemy.GetComponent<Animator>().SetBool("isIdle", false);
				enemy.GetComponent<Animator>().SetBool("isAttacking" ,false);
				
				isAlive = false;
			
		}
	
		if(hasCollided == true && isAlive == true){
			//call hasColided IEunermerator
			StartCoroutine(goForATime());

		}
		

		
	}
	
	IEnumerator goForATime(){
		//yield return new WaitForSeconds(1);
		float timePassed = 0;
		Vector3 move = new Vector3(Random.Range(-8.0f,8.0f), 0, 0);
		while (timePassed < 3){
			 
			transform.Translate(move * 0.1f * Time.deltaTime);
         // Code to go left here
			timePassed += Time.deltaTime;
			
 
			yield return null;
		}	

		hasCollided = false;
	}

	
	void OnTriggerEnter(Collider other){

		if(other.gameObject == player){
			attackTrigger = 1;
			
			Debug.Log("Player Collision");
		}
		
		if(other.gameObject.tag == "remClone"){
				hasCollided = true;
				Debug.Log("Enemy Collision-------------------------------------------------------------------");
		}
		
	}
	
	void OnTriggerExit(Collider other){
		attackTrigger = 0;
				if(other.gameObject.tag == "remClone"){
				hasCollided = false;
				Debug.Log("Enemy Collision");
		}
		
	}
	
	void OnCollisionEnter(Collision collision){
			if(collision.gameObject.tag == "remCube(Clone)" || collision.gameObject.tag == "remCube"){
				hasCollided = true;
			}
				
	}	
}
