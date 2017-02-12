using UnityEngine;
using System.Collections;

public class Ejercicio4 : MonoBehaviour {

    MeshRenderer render;
    Color colorActual;

    // Use this for initialization
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseEnter()
    {
        colorActual = render.material.color;
        float r = Random.Range(0F, 1.0F),
            g = Random.Range(0F, 1.0F),
            b = Random.Range(0F, 1.0F);
        render.material.color = new Color(r, g, b);
    }

    void OnMouseExit()
    {
        render.material.color = colorActual;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            colorActual = render.material.color;
        }
    }
}
