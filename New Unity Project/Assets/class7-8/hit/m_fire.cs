using UnityEngine;
using System.Collections;

public class m_fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//float mf = Input.GetAxis ("Fire1"); //print value
		//Debug.Log (mf); // only 0 and 1

		//print bool
		bool mbool_hold = Input.GetButton ("Fire1");
		bool mbool_down = Input.GetButton ("Fire1");
		bool mbool_up = Input.GetButton ("Fire1");
		if (mbool_hold) {

		}
		if (mbool_down) {
		
		}
		if(mbool_up){

		}
	}
}
