using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ejercicio2 : MonoBehaviour {
	
	public Rect rectEnunciado;
	Rect rectEjercicio;


	public int xEnunciado;
	private int yEnunciado = 35;
	public int widthEnunciado = 500;
	public int heightEnunciado = 100;

	// Use this for initialization
	void Start () {
	}

	void Update() {
		xEnunciado = (Screen.width);
	}
	void OnGUI(){
		rectEnunciado = new Rect(xEnunciado,yEnunciado, widthEnunciado, heightEnunciado);
		GUI.Label (rectEnunciado, "Pulsa espacio para mostrar el otro mensaje");
	}
}
