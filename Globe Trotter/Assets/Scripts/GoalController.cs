using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour {

	public GameObject winCanvas;
	public GameObject gameCanvas;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			Time.timeScale = 0;
			gameCanvas.SetActive(false);
			winCanvas.SetActive(true);
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	// Uncomment this section when level 3 is introduced. 
	public void NextLevel()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadCredits()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Credits");
	}
}
