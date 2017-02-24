using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ejercicio6 : MonoBehaviour {

	public GUIStyle buttonStyle;
	public GUIStyle windowStyle;

	Rect window;
	float windowWidth;
	float windowHeight;
	float buttonInitialHeight;
	float buttonWidth;
	float buttonHeight;
	float buttonSeparator;

	// Use this for initialization
	void Start () {
		buttonSeparator = 10;
		buttonInitialHeight = 17 + buttonSeparator;
		buttonWidth = 100;
		buttonHeight = 20;
		windowWidth = buttonWidth + buttonSeparator * 2;
		windowHeight = (buttonHeight + buttonSeparator) * 3 + buttonInitialHeight;
		window = new Rect (50, 10, windowWidth, windowHeight);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {
		window = ClampToScreen(GUI.Window(0,window,Drag,"Menú",windowStyle));

	}
	void Drag(int windowID) {
		GUI.DragWindow(new Rect(0, 0, windowWidth, 20));
		if (GUI.Button (new Rect (buttonSeparator, buttonInitialHeight, buttonWidth, buttonHeight), "Ejercicio 2",buttonStyle))
			CargarEjercicio ("2");

		if (GUI.Button(new Rect(buttonSeparator, buttonInitialHeight + (buttonSeparator + buttonHeight), buttonWidth, buttonHeight), "Ejercicio 3",buttonStyle))
			CargarEjercicio ("3");

		if (GUI.Button(new Rect(buttonSeparator, buttonInitialHeight + (buttonSeparator + buttonHeight) * 2, 100, 20), "Ejercicio 4",buttonStyle))
			CargarEjercicio ("4");
	}

	Rect ClampToScreen(Rect r)
	{
		r.x = Mathf.Clamp(r.x,0,Screen.width-r.width);
		r.y = Mathf.Clamp(r.y,0,Screen.height-r.height);
		return r;
	}

	public void CargarEjercicio(string numEjercicio)
	{
		SceneManager.LoadScene("EscenaEjercicio" + numEjercicio);
	}
}
