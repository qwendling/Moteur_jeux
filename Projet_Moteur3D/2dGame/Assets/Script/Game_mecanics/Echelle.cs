﻿using UnityEngine;
using System.Collections;

//By Nathan URBAIn

public class Echelle : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(Input.GetKey("up")) {
			other.gameObject.transform.position += Vector3.up * (Time.deltaTime*4);
		}

		if(Input.GetKey("down")) {
			other.gameObject.transform.position -= Vector3.up * (Time.deltaTime*4);
		}
	}

}
