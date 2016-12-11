﻿using UnityEngine;
using System.Collections;

//Nathan URBAIN 
//Utilisation du cheatCode

public class CheatCode : MonoBehaviour {

	public bool isCheated;
	public GameObject CheatPanel;
	public GameObject perso;
	private bool _ison = false;
	private Rigidbody2D gravity;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (isCheated) {
			Time.timeScale = 0f;
			CheatPanel.SetActive (true);
		} else {
			Time.timeScale = 1f;
			CheatPanel.SetActive (false);
		}

		if(Input.GetKeyDown(KeyCode.C))
			isCheated = !isCheated;

		if (_ison == true) {
			gravity = perso.GetComponent<Rigidbody2D> ();
			gravity.gravityScale = 0;
			if (Input.GetKey ("up")) {
				perso.transform.position += Vector3.up * (Time.deltaTime * 6);
			}

			if (Input.GetKey ("down")) {
				perso.transform.position -= Vector3.up * (Time.deltaTime * 6);
			}
		} else {
			gravity = perso.GetComponent<Rigidbody2D> ();
			gravity.gravityScale = 3;
		}
	}

	public void no()
	{
		isCheated = !isCheated;
		CheatPanel.SetActive(false);
		_ison = false;
	}
		
	public void yes()
	{
		isCheated = !isCheated;
		CheatPanel.SetActive(false);
		_ison = true;
	}
}
