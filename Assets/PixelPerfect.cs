using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfect : MonoBehaviour {

	public float scale = 1.0f;
	public float PPU = 16.0f;

	// Use this for initialization
	void Start () {
		// Camera Size = x / ((( x / y ) * 2 ) * s )
		Camera camera = GetComponent<Camera>();
		var x = (float)Screen.width;
		var y = (float)Screen.height;
		var s = PPU * scale;
		camera.orthographicSize = x / ((( x / y ) * 2.0f ) * s );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
