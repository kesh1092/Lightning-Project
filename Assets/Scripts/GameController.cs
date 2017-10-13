using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	//public GameObject hazard;
	//public Vector3 spawnValues;
	//public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public GameObject text;
	public GameObject text2;

	//public GUIText scoreText;
	//public GUIText restartText;
	//public GUIText gameOverText;

	private bool gameOver;
	private bool gameWon;
	private bool restart;
	//private int score;

	void Start()
	{
		gameOver = false;
		gameWon = false;
		restart = false;
		//restartText.text = " ";
		//gameOverText.text = " ";
		//score = 0;
		//UpdateScore();
		//StartCoroutine (SpawnWaves());
	}

	void Update()
	{
		if (restart) 
		{
			text.gameObject.SetActive(true);
			if (Input.GetKeyDown (KeyCode.R)) 
			{
				Application.LoadLevel(Application.loadedLevel);
				text.gameObject.SetActive(false);
			}
		}
			
		if (gameOver) 
		{
			//restartText.text = "Press 'R' for Restart";
			restart = true;
			//break;
		}
		if (gameWon) 
		{ 
			text2.gameObject.SetActive(true);
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				Application.LoadLevel(Application.loadedLevel);
				text2.gameObject.SetActive(false);
			}
			if (Input.GetKeyDown (KeyCode.R)) 
			{
				Application.LoadLevel(Application.loadedLevel);
				text2.gameObject.SetActive(false);
			}
		}
	}

	//IEnumerator SpawnWaves()
	//{
	//	yield return new WaitForSeconds (startWait);
	//	while(true)
	//	{
	//		for (int i=0; i < hazardCount; i++) 
	//		{
	//			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
	//			Quaternion spawnRotation = Quaternion.identity;
	//			Instantiate (hazard, spawnPosition, spawnRotation);
	//			yield return new WaitForSeconds (spawnWait);
	//		}
	//		yield return new WaitForSeconds (waveWait);
	//
	//		if (gameOver) 
	//		{
	//			restartText.text = "Press 'R' for Restart";
	//			restart = true;
	//			//break;
	//		}
	//	}
	//}

	//public void AddScore(int newScoreValue)
	//{
	//	score += newScoreValue;
	//	UpdateScore();
	//}

	//void UpdateScore()
	//{
	//	scoreText.text = "Score: " + score;
	//}

	public void GameOver()
	{
		//gameOverText.text = "Game Over!";
		gameOver = true;
	}
	public void GameWon()
	{
		//gameOverText.text = "Game Over!";
		gameWon = true;
	}
}