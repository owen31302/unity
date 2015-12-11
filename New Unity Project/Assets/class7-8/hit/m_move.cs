using UnityEngine;
using System.Collections;

public class m_move : MonoBehaviour {

	private float t = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			this.transform.position = this.transform.position + this.transform.forward*t;
		} else if(Input.GetKey(KeyCode.S)) {
			this.transform.position = this.transform.position - this.transform.forward*t;
		}else if(Input.GetKey(KeyCode.A)) {
			this.transform.position = this.transform.position - this.transform.right*t;
		}else if(Input.GetKey(KeyCode.D)) {
			this.transform.position = this.transform.position + this.transform.right*t;
		}

		/*float fv = Input.GetAxis ("Vertical");
		float fh = Input.GetAxis ("Horizontal");
		//Debug.Log (fv);
		this.transform.position = this.transform.position + this.transform.forward * fv;
		this.transform.position = this.transform.position + this.transform.right * fh; */

		//bool mbool = Input.GetButton ("Jump");
	}
}
