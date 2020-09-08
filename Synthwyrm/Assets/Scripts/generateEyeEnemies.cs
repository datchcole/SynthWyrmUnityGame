using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateEyeEnemies : MonoBehaviour {

	public GameObject enemy;   ///parent
	public int xPos;
	public int zPos;
	public int xRot;
	public int enemyCount;
	public Transform parentObj;
	public GameObject childEnemy;
	
	void Start () {
		StartCoroutine(enemyDrop());
	}
	
	IEnumerator enemyDrop(){
			
			while(enemyCount < 44){
				xPos = Random.Range(-74, -12);
				zPos = Random.Range(513,580);
				xRot = Random.Range(0,360);
					//enemy.transform.SetParent(newParent);
					//enemy.transform.SetParent(newParent, false);
					
					GameObject newEnemy = Instantiate(enemy, new Vector3(xPos, 2, zPos), Quaternion.Euler(0, xRot,0));
					newEnemy.transform.localScale = childEnemy.transform.localScale;
					yield return new WaitForSeconds(0.2f);
					enemyCount += 1;
					Debug.Log("enemyCount = " + enemyCount);
			}
	}

}
