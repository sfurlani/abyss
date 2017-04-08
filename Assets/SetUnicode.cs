using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUnicode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text text = GetComponent<Text>();
		text.text = "\u2514\u2500\u2510";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
