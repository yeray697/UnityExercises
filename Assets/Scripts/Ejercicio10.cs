using UnityEngine;
using System.Collections;

public class Ejercicio10 : MonoBehaviour {

	public GameObject cubo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cubo.transform.Rotate(Quaternion.Euler(new Vector3(0,45,0)).eulerAngles * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Space)) {
			Time.timeScale = 0;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Time.timeScale = 1;
		}
	}

	void FixedUpdate(){
		float horizontal = Input.GetAxis("Horizontal"); 
		float vertical = Input.GetAxis("Vertical");
		Vector3 movimiento = new Vector3();
		if (horizontal != 0) {
			movimiento.x = horizontal * Time.fixedDeltaTime * Time.timeScale;
		}
		if (vertical != 0) {
			movimiento.y = vertical * Time.fixedDeltaTime * Time.timeScale;
		}
		cubo.transform.Translate(movimiento,Space.World);
	}
	void OnGUI(){
		GUI.Label (new Rect (10, 10, 100, 30), "TimeScale: " + Time.timeScale);
	}
}
