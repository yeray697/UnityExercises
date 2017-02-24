using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ejercicio9 : MonoBehaviour {
	private float velocidad = 4;
	public float puntos;
	private Rect labelRect;
	private GameObject lastObject;
	public int estadoPartida; 	// -1 = pausa
								// 0 = activa
								// 1 = ganador
								// 2 = perdedor
	public int nObjetos;


	private float boxX;
	private float boxY;
	private float boxWidth;
	private float boxHeight;
	private float separacionHeight = 25;
	private float separacionWidth = 20;

	private float guiHeight = 20;
	private float guiWidth;
	private float buttonWidth;

	// Use this for initialization
	void Start () {
		labelRect = new Rect (5,0,100,50);
		puntos = 50;
		estadoPartida = 0;
		nObjetos = GameObject.FindGameObjectsWithTag ("puntos_2").Length +
			GameObject.FindGameObjectsWithTag ("puntos_3").Length +
			GameObject.FindGameObjectsWithTag ("puntos_4").Length +
			GameObject.FindGameObjectsWithTag ("puntos_5").Length;
	}
	
	// Update is called once per frame
	void Update () {
		separacionWidth = (Screen.width / 40);
		boxWidth = (Screen.width) / 2;
		if (estadoPartida == -1) {
			boxHeight = guiHeight * 3 + separacionHeight * 2;
		} else {
			boxHeight = (guiHeight + separacionHeight) * 2;
		}
		buttonWidth = boxWidth - separacionWidth * 2;
		boxX = (Screen.width - boxWidth) / 2;
		boxY = (Screen.height - boxHeight) / 2;

		if (estadoPartida == 0 && Input.GetKeyDown (KeyCode.Escape)) {
			estadoPartida = -1;
		}
		if (estadoPartida == 0) { //Partida activa
			Vector3 movimiento = new Vector3 ();
			float x = Input.GetAxis ("Horizontal");
			float z = Input.GetAxis ("Vertical");
			if (x != 0) {
				movimiento.x = Time.deltaTime * velocidad * x;
			}
			if (z != 0) {
				movimiento.z = Time.deltaTime * velocidad * z;
			}
			transform.Translate (movimiento);
		}

		if (puntos <= 0) {
			estadoPartida = 2;
		} else if (nObjetos == 0) {
			estadoPartida = 1;
		}
	}

	void OnCollisionEnter(Collision collision){
		int puntosActuales = 0;
		string tag = collision.collider.tag;
		switch (tag) {
		case "puntos_2":
			puntosActuales = 2;
			break;
		case "puntos_3":
			puntosActuales = 3;
			break;
		case "puntos_4":
			puntosActuales = 4;
			break;
		case "puntos_5":
			puntosActuales = 5;
			break;
		default:
			return;
		}
		if (lastObject != null) {
			bool anteriorEsCubo = (lastObject.tag == "puntos_2" || lastObject.tag == "puntos_3");
			bool esCubo = (collision.collider.tag == "puntos_2" || collision.collider.tag == "puntos_3");
			if ((!anteriorEsCubo && esCubo) || (anteriorEsCubo && !esCubo)) {
				puntosActuales /= -2; //Invertimos el resultado para sumar luego
				Destroy(lastObject);
				Destroy (collision.gameObject);
				lastObject = null;
				puntos -= puntosActuales;
				nObjetos -= 2;
				return;
			}
			puntos -= puntosActuales;
		}
		if (tag.StartsWith("puntos_")) {
			lastObject = collision.gameObject;
		}
	}

	void OnGUI(){
		if (estadoPartida == 0) {
			GUI.Label (labelRect, "Puntos: " + puntos);
		} else if (estadoPartida == -1) {
			GUI.Box (new Rect (boxX, boxY, boxWidth, boxHeight), "Pausa");
			if (GUI.Button (new Rect (boxX + separacionWidth, boxY + separacionHeight, buttonWidth, guiHeight), "Reanudar")) {
				Reanudar ();
			}
			if (GUI.Button (new Rect (boxX + separacionWidth, boxY + separacionHeight * 2, buttonWidth, guiHeight), "Reiniciar")) {
				Reiniciar ();
			}
			if (GUI.Button (new Rect (boxX + separacionWidth, boxY + separacionHeight * 3, buttonWidth, guiHeight), "Salir")) {
				Salir ();
			}
		} else {
			string mensaje;
			if (estadoPartida == 1) {
				mensaje = "Has ganado con "+puntos+ " puntos";
			} else { //estadoPartida == 2
				mensaje = "Has perdido";
			}
			GUI.Box (new Rect (boxX, boxY, boxWidth, boxHeight), mensaje);
			if (GUI.Button (new Rect (boxX + separacionWidth, boxY + separacionHeight, buttonWidth, guiHeight), "Reiniciar")) {
				Reiniciar ();
			}
			if (GUI.Button (new Rect (boxX + separacionWidth, boxY + separacionHeight * 2, buttonWidth, guiHeight), "Salir")) {
				Salir ();
			}
		}
	}
	private void Reanudar(){
		estadoPartida = 0;
	}
	private void Reiniciar(){
		SceneManager.LoadScene ("EscenaEjercicio9");
	}
	private void Salir(){
		SceneManager.LoadScene ("main");
	}
}
