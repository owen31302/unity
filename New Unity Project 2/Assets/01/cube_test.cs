using UnityEngine;
using System.Collections;

public class cube_test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("This is :"+ this.name);
		Debug.Log ("The other is :"+ other.name); 
	}
}
