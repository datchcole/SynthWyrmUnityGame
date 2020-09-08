using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeRemGenerator : MonoBehaviour {

	public GameObject enemy;   //parent
	public GameObject childEnemy;
	public GameObject triggerBox;
	public float rangeX1;
	public float rangeZ1;
	public float rangeX2;
	public float rangeZ2;
	public float xPos;
	public float zPos;
	public int xRot;
	public int enemyCount;
	public bool playerTriggeredSpawn;
	public bool notYetTriggered = true;  

	void Start () {
		//StartCoroutine(enemyDrop());
	}

	void Update(){
		playerTriggeredSpawn = GameObject.Find("spawnTrigger").GetComponent<boxColliderNotfiySpawner>().playerDSpawnTrigger;
		if(playerTriggeredSpawn == true  && notYetTriggered == true){     //if player in box trigger object
			StartCoroutine(enemyDrop());
		}
	}
	
	IEnumerator enemyDrop(){
			
			rangeX1 = triggerBox.transform.position.x - 50;
			rangeX2 = triggerBox.transform.position.x + 50;
			rangeZ1 = triggerBox.transform.position.z - 50;
			rangeZ2 = triggerBox.transform.position.z + 50;

			while(enemyCount < 40){
				xPos = Random.Range(rangeX1, rangeX2);
				zPos = Random.Range(rangeZ1, rangeZ2);
				xRot = Random.Range(0,360);
					GameObject newEnemy = Instantiate(enemy, new Vector3(xPos, 1.193f, zPos), Quaternion.Euler(0, xRot,0));
					//newEnemy.transform.localScale = childEnemy.transform.localScale;
					newEnemy.transform.localScale -= new Vector3(1,1,1) * 0.1f;
					newEnemy.gameObject.tag = "remClone";
					//newEnemy.transform.Translate(newEnemy.transform.position.x, 1.193f, newEnemy.transform.position.z);
					yield return new WaitForSeconds(0.2f);
					enemyCount += 1;
					Debug.Log("enemyCount = " + enemyCount);
			}

		notYetTriggered = false;
	}

}
