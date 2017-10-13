using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
//	public int incTest = 0; //doesnt increment
	public void StartGame()
	{
//		incTest++;
		// "Stage1" is the name of the first scene we created.
		//originally:         Application.LoadLevel("Stage1");
		SceneManager.LoadScene("Stage1");
	}
}

