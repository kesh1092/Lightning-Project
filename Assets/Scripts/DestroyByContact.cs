using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour 
{ //Order is ignored for destroy, as the object isnt immedietly destroyed but instead put in a queue to be destroyed at the end of each frame.

	public GameObject explosion;
	public GameObject playerExplosion;
	//public int scoreValue;
	private GameController gameController;
	public GameObject text;

	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if(gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null) 
		{
			Debug.Log("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log (other.name);
		//if (other.tag == "Boundary") 
		//{
		//	return;
		//}
		//Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player") 
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver();
			Destroy(other.gameObject);
		}
		//gameController.AddScore (scoreValue);
		//Destroy(other.gameObject);
		//Destroy(gameObject);
	}
}