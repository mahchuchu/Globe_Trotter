using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZoneScript : MonoBehaviour {

	public AudioSource deathSound;

	// This function reloads the scene when the player goes out of bounds. 
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			deathSound.Play();
		}
	}
}
