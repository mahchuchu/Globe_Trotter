﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

	public static int Score;
	public Text scoreText;

	// Initializes the score UI. 
	void Start () {
		SetCountText();
	}
	
	// Rotates the coins.
	void Update () {
		transform.Rotate (new Vector3(45,0,0) * Time.deltaTime);
	}

	// This function picks up coins and keeps count displaying it in a text field.
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			Score++;
			SetCountText();
			Debug.Log(Score);
		}
	}

	// Sets count text to 0 at beggining of the game. 
	void SetCountText()
	{
		scoreText.text = "Score: " + Score.ToString();
	}


}
