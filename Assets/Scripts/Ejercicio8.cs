using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class Ejercicio8 : MonoBehaviour {

    private float boxX;
    private float boxY;
    private float boxWidth;
    private float boxHeight;
    private float separacionHeight = 25;
    private float separacionWidth = 20;

    private float guiHeight = 20;
    private float guiWidth;
    private float textFieldWidth;

    private bool enviado;

    private string nombre = "";
    private string apellidos = "";
    private string edad = "";

    // Use this for initialization
    void Start () {
        enviado = false;
    }
	
	// Update is called once per frame
	void Update () {
        boxX = (Screen.width) / 2 - (Screen.width) / 4;
        boxY = (Screen.height) / 2 - (Screen.height) / 4;
        boxWidth = (Screen.width) / 2;
        boxHeight = guiHeight + separacionHeight * 6;
        textFieldWidth = (Screen.width / 3);
        guiWidth = (Screen.width / 8);
        separacionWidth = (Screen.width / 40);
    }
    void OnGUI()
    {
        GUI.Box(new Rect(boxX, boxY, boxWidth, boxHeight), "Datos del usuario");
        GUI.Label(new Rect(boxX + separacionWidth, boxY + separacionHeight, guiWidth, guiHeight), "Nombre");
        nombre =  GUI.TextField(new Rect(boxX + separacionWidth + guiWidth, boxY + separacionHeight, textFieldWidth, guiHeight), nombre);
        GUI.Label(new Rect(boxX + separacionWidth, boxY + separacionHeight * 2, guiWidth, guiHeight), "Apellidos");
        apellidos = GUI.TextField(new Rect(boxX + separacionWidth + guiWidth, boxY + separacionHeight * 2, textFieldWidth, guiHeight), apellidos);
        GUI.Label(new Rect(boxX + separacionWidth, boxY + separacionHeight * 3, guiWidth, guiHeight), "Edad");
        edad = GUI.TextField(new Rect(boxX + separacionWidth + guiWidth, boxY + separacionHeight * 3, textFieldWidth, guiHeight), edad);
        if (GUI.Button(new Rect(boxX + separacionWidth, boxY + separacionHeight * 4, textFieldWidth + guiWidth, guiHeight), "Enviar"))
        {
            enviado = true;
        }
        if (GUI.Button(new Rect(boxX + separacionWidth, boxY + separacionHeight * 5, textFieldWidth + guiWidth, guiHeight), "Limpiar"))
        {
            nombre = "";
            apellidos = "";
            edad = "";
        }
        edad = Regex.Replace(edad, "[^0-9]", "");
        if (enviado)
        {
            GUI.Label(new Rect(boxX + separacionWidth, boxY + separacionHeight * 6, textFieldWidth + guiWidth, guiHeight), "Enviado ...");
        }
    }
}
