
using UnityEngine;

public class ExitScript : MonoBehaviour {

	public void ExitApp()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
