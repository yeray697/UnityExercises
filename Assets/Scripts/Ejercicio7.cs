using UnityEngine;
using System.Collections;

public class Ejercicio7 : MonoBehaviour {

    private float boxX;
    private float boxY;
    private float boxWidth;
    private float boxHeight;

    float value1 = 50;
    float topValue = 100;
    float bottomValue = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        boxX = (Screen.width) / 2.5F - (Screen.width) / 4;
        boxY = (Screen.height) / 2.8F - (Screen.height) / 4;
        boxWidth = (Screen.width) / 1.5F;
        boxHeight = (Screen.height) / 1.2F;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(boxX, boxY, boxWidth, boxHeight), "Ecualizador");

        value1 = GUI.VerticalSlider(new Rect(5,5,25,400), value1, topValue, bottomValue);
    }
}
