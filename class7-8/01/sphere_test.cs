using UnityEngine;
using System.Collections;

public class sphere_test : MonoBehaviour {

	public Transform m_trans;
	public Vector3 v;
	public float t = 0.0f;

	// Use this for initialization
	void Start () {
		v = this.transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.Translate (new Vector3(1.0f, 0.0f, 0.0f), m_trans);
		//this.transform.RotateAround (m_trans.position, Vector3.up, 1.0f);

		//Quaternion des = m_trans.transform.rotation;
		//Quaternion step_turn = Quaternion.Lerp (this.transform.rotation, des, 0.5f);
		//this.transform.rotation = step_turn;

		//this.transform.forward = m_trans.transform.forward;

		//this.transform.forward = Vector3.Lerp (v, m_trans.transform.forward, t);
		//t += 0.01f;



		//this.transform.position = m_trans.transform.position;

		/*Vector3 v1 = m_trans.transform.position - this.transform.position;
		float d = v1.magnitude;
		v1.Normalize();

		Vector3 v = Vector3.RotateTowards (this.transform.forward, v1, 0.1f, 0.1f);
		this.transform.forward = v.normalized;

		if (d < 0.1f) {
			this.transform.position = m_trans.transform.position;
		} else {
			this.transform.position = this.transform.position+ this.transform.forward * 0.1f;
		}*/

		this.transform.position = Vector3.MoveTowards (this.transform.position, m_trans.transform.position, 1f);

	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("This is :"+ this.name);
		Debug.Log ("The other is :"+ other.name); 
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.green; //換色
		Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.forward * 5.0f); //畫出正面線
		//Gizmos.DrawWireSphere(this.transform.position, 3.0f); //畫出球狀
	}
}
