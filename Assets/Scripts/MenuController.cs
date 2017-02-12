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

    public void CargarEjercicio(string ejercicio)
    {
        SceneManager.LoadScene(ejercicio);
    }

	public void Ejercicio2() {
        CargarEjercicio(ejercicio+"2");
	}

	public void Ejercicio3() {
        CargarEjercicio(ejercicio+"3");
	}

	public void Ejercicio4() {
        CargarEjercicio(ejercicio+"4");
	}

	public void Ejercicio5() {
        CargarEjercicio(ejercicio+"5");
	}

	public void Ejercicio6() {
        CargarEjercicio(ejercicio+"6");
	}

	public void Ejercicio7() {
        CargarEjercicio(ejercicio+"7");
	}

	public void Ejercicio8() {
        CargarEjercicio(ejercicio+"8");
	}

	public void Ejercicio9() {
        CargarEjercicio(ejercicio+"9");
	}

	public void Ejercicio10() {
        CargarEjercicio(ejercicio+"10");
	}
}
