
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagementController : MonoBehaviour {

	public void LoadGame()
	{
		SceneManager.LoadScene("Level 1");
	}

	public void LoadCredits()
	{
		SceneManager.LoadScene("Credits");
	}

	public void LoadMenuFromCredits()
	{
		SceneManager.LoadScene("Menu");
	}
}
