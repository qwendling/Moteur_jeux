﻿using UnityEngine;
using System.Collections;

public class ChangeTime : MonoBehaviour {
	public GameObject _Past;
	public GameObject _Futur;
	public GameObject _Filter;
	int i=0;
	bool isPast=true;
	bool Verif=true;

	// Use this for initialization
	void Start () {
		_Past.SetActive (true);
		_Futur.SetActive (false);
		_Filter.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && Verif){
				_Past.SetActive (!isPast);
				_Futur.SetActive (isPast);
				_Filter.SetActive (!isPast);
				isPast = !isPast;
				print ("hello");
				Verif = false;
		}
	}
	public void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player" && !Verif){
			Verif = true;
		}
	}
}