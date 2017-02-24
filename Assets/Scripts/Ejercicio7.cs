using UnityEngine;
using System.Collections;

public class Ejercicio7 : MonoBehaviour
{

    private float boxX;
    private float boxY;
    private float boxWidth;
    private float boxHeight;
    private float separationX;
    private float separationY;

    private float sliderWidth;
    private float sliderHeight;
    private float sliderSeparation;

    float value1 = 50;
    float value2 = 50;
    float value3 = 50;
    float value4 = 50;
    float value5 = 50;
    float value6 = 50;
    float value7 = 50;
    float value8 = 50;
    float value9 = 50;
    float value10 = 50;
    float topValue = 100;
    float bottomValue = 0;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        boxHeight = (Screen.height) / 1.2F;
        sliderSeparation = (Screen.width) / 50;
        separationX = (Screen.width) / 60;
        separationY = 20;
        sliderWidth = (Screen.width) / 30;
        sliderHeight = boxHeight - separationY * 2;
        boxWidth = separationX + (sliderSeparation + sliderWidth) * 9 + sliderWidth;
        boxX = (Screen.width - boxWidth)/2 ;
        boxY = (Screen.height - boxHeight) /2;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(boxX, boxY, boxWidth, boxHeight), "Ecualizador");

        value1 = GUI.VerticalSlider(new Rect(boxX + separationX, boxY + separationY, sliderWidth, sliderHeight), value1, topValue, bottomValue);
        value2 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth), boxY + separationY, sliderWidth, sliderHeight), value2, topValue, bottomValue);
        value3 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 2, boxY + separationY, sliderWidth, sliderHeight), value3, topValue, bottomValue);
        value4 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 3, boxY + separationY, sliderWidth, sliderHeight), value4, topValue, bottomValue);
        value5 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 4, boxY + separationY, sliderWidth, sliderHeight), value5, topValue, bottomValue);
        value6 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 5, boxY + separationY, sliderWidth, sliderHeight), value6, topValue, bottomValue);
        value7 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 6, boxY + separationY, sliderWidth, sliderHeight), value7, topValue, bottomValue);
        value8 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 7, boxY + separationY, sliderWidth, sliderHeight), value8, topValue, bottomValue);
        value9 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 8, boxY + separationY, sliderWidth, sliderHeight), value9, topValue, bottomValue);
        value10 = GUI.VerticalSlider(new Rect(boxX + separationX + (sliderSeparation + sliderWidth) * 9, boxY + separationY, sliderWidth, sliderHeight), value10, topValue, bottomValue);
    }
}