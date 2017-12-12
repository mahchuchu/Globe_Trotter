using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

	public static int Score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		SetCountText();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(45,0,0) * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			Score++;
			SetCountText();
			Debug.Log(Score);
		}
	}

	void SetCountText()
	{
		scoreText.text = "Score: " + Score.ToString();
	}
}
