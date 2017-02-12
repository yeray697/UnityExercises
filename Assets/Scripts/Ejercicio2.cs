using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ejercicio2 : MonoBehaviour {

    public Rect rectEnunciado;
    public Rect rectEjercicio;

    private int xEnunciado;
    private int yEnunciado = 35;
    private int widthEnunciado = 260;
    private int heightEnunciado = 100;

    private int xEjercicio;
    private int yEjercicio;
    private int widthEjercicio = 500;
    private int heightEjercicio = 100;

    bool spaceClicked;

	// Use this for initialization
	void Start () {
        spaceClicked = false;
    }

	void Update()
    {
        xEnunciado = (Screen.width) / 2 - (Screen.width) / 8;
        xEjercicio = (Screen.width) / 2 - (Screen.width) / 8;
        yEjercicio = (Screen.height) / 2 - (Screen.height) / 8;
        widthEjercicio = (Screen.width) / 4;
        heightEjercicio = (Screen.height) / 4;
        widthEnunciado = (Screen.width) / 4;
        heightEnunciado = (Screen.height) / 4;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceClicked = !spaceClicked;
        }
    }
	void OnGUI(){
        GUI.color = Color.black;
		rectEnunciado = new Rect(xEnunciado, yEnunciado, widthEnunciado, heightEnunciado);
        rectEjercicio = new Rect(xEjercicio, yEjercicio, widthEjercicio, heightEjercicio);

        GUI.Label (rectEnunciado, "Pulsa espacio para mostrar el otro mensaje");

        if (spaceClicked)
        {
            GUI.Label(rectEjercicio, "Soy el label que aparece con el espacio. Pulsa de nuevo para que desaparezca");
        }
    }
}
