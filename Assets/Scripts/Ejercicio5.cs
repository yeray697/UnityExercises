using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ejercicio5 : MonoBehaviour {

    public GameObject esfera;
    public GameObject menu;
    private float speed = 3F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 0)
            {
                Reanudar();
            } else
            {
                Pausar();
            }
        }
        esfera.transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 4)-2, transform.position.y,transform.position.z);
    }

    public void Salir()
    {
        Time.timeScale = 1F;
        SceneManager.LoadScene("main");
    }

    public void Reanudar()
    {
        Time.timeScale = 1F;
        menu.SetActive(false);
    }
    void Pausar()
    {
        Time.timeScale = 0F;
        menu.SetActive(true);
    }
}
