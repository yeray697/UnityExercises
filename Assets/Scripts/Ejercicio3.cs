using UnityEngine;
using System.Collections;

public class Ejercicio3 : MonoBehaviour {

    MeshRenderer render;
    Color colorActual;

    // Use this for initialization
    void Start () {
        render = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseEnter()
    {
        colorActual = render.material.color;
        render.material.color = Color.blue;
    }

    void OnMouseExit()
    {
        render.material.color = colorActual;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            colorActual = Color.blue;
            render.material.color = colorActual;

        }
    }
}
