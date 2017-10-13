using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Square : MonoBehaviour {
	public float speed = 66F;
	void Update() {

		if (Input.GetKey(KeyCode.LeftBracket))
			transform.Rotate (new Vector3 (0, 0, 1) * Time.deltaTime * speed); 
		if (Input.GetKey(KeyCode.RightBracket))
			transform.Rotate (new Vector3 (0, 0, -(1)) * Time.deltaTime * speed); 
	}
}