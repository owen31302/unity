using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Input.mousePosition);

		// Create ballet dynamically with left mouse key
		// Input.GetMouseButtonDown(0)//left
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			//Debug.Log("This is left mouse click: " + this.name);
			GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			sphere.transform.position = this.transform.position;
		}
	}
}
