using UnityEngine;
using System.Collections;

public class m_rig : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector3 (1.0f, 10.0f, 0.0f);
		}
		rb.velocity = new Vector3 (1.0f, rb.velocity.y, 0.0f);
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.green; //換色
		Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.forward * 5.0f); //畫出正面線
		Gizmos.DrawWireSphere(this.transform.position, 3.0f); //畫出球狀
	}
}
