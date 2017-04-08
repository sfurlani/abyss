using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour {

	public float dx = 0.5f;
	public float dy = 1.0f;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		float x = pos.x + (Input.GetKeyUp(KeyCode.RightArrow)?dx:0) + (Input.GetKeyUp(KeyCode.LeftArrow)?-dx:0);
		float y = pos.y + (Input.GetKeyUp(KeyCode.UpArrow)?dy:0) + (Input.GetKeyUp(KeyCode.DownArrow)?-dy:0);
		transform.position = new Vector3(x, y, pos.z);
	}
}
