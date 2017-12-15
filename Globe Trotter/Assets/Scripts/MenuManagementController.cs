
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagementController : MonoBehaviour {

	public void LoadGame()
	{
		SceneManager.LoadScene("Level 1");
	}

	public void LoadHowToPlay()
	{
		SceneManager.LoadScene("How To Play");
	}

	public void LoadCreditsFromLevelThree()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Credits");
	}

	public void LoadMenuFromCredits()
	{
		SceneManager.LoadScene("Menu");
	}

	public void LoadMenuFromHowToPlay()
	{
		SceneManager.LoadScene("Menu");
	}

	public void LoadCreditsFromMenu()
	{
		SceneManager.LoadScene("Credits");
	}
}
