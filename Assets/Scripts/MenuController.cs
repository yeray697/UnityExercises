using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour {

	private string ejercicio = "EscenaEjercicio";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Ejercicio2() {
		SceneManager.LoadScene (ejercicio+"2");
	}

	public void Ejercicio3() {
		SceneManager.LoadScene (ejercicio+"3");
	}

	public void Ejercicio4() {
		SceneManager.LoadScene (ejercicio+"4");
	}

	public void Ejercicio5() {
		SceneManager.LoadScene (ejercicio+"5");
	}

	public void Ejercicio6() {
		SceneManager.LoadScene (ejercicio+"6");
	}

	public void Ejercicio7() {
		SceneManager.LoadScene (ejercicio+"7");
	}

	public void Ejercicio8() {
		SceneManager.LoadScene (ejercicio+"8");
	}

	public void Ejercicio9() {
		SceneManager.LoadScene (ejercicio+"9");
	}

	public void Ejercicio10() {
		SceneManager.LoadScene (ejercicio+"10");
	}
}
