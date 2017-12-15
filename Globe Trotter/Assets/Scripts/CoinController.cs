using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

	public static int Score;
	public static int hiScore;
	public Text scoreText;
	public Text hiScoreText;
	public AudioSource audiosource;


	// Initializes the score UI. 
	void Start ()
	{
		Score = 0;
		hiScore = 0;
		SetCountText ();

		if (PlayerPrefs.HasKey ("HighScore")) {
			hiScore = PlayerPrefs.GetInt ("HighScore");
		}

	}
	
	// Rotates the coins.
	void Update () {
		transform.Rotate (new Vector3(45,0,0) * Time.deltaTime);

		if (Score > hiScore){
			hiScore = Score;
			PlayerPrefs.SetInt("HighScore", hiScore);
		}

		hiScoreText.text = "High Score: " + hiScore.ToString();

	}

	// This function picks up coins and keeps count displaying it in a text field.
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			audiosource.Play ();
			Score++;
			SetCountText();
			gameObject.SetActive (false);
			Debug.Log(Score);
		}
	}

	// Sets count text to 0 at beggining of the game. 
	void SetCountText()
	{
		scoreText.text = "Score: " + Score.ToString();

	}


}
