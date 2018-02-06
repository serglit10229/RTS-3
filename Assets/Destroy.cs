using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public string enemyTag;

	void OnTriggerEnter(Collider col){
		
		if(col.gameObject.tag == enemyTag)
		{
			//yield WaitForSeconds(delay);
			Destroy (gameObject);
			Debug.Log("Destroy");
		}
	}
}
