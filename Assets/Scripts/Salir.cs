using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Salir : MonoBehaviour {

	private string escenaMenu = "main";
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && !SceneManager.GetActiveScene().name.Equals(escenaMenu)) {
			GoMenu ();
		}
	}

	public void Exit() {
		Application.Quit ();
	}

	public void GoMenu() {
		SceneManager.LoadScene (escenaMenu);
	}
}
