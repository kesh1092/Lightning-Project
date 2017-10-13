using System.Collections;
using UnityEngine;

public class ShotScript : MonoBehaviour {

	public int damage = 1;
	public bool isEnemyShot;// set to true in shot prefab

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 4);
	}
	
 
}
