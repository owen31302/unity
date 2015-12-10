using UnityEngine;
using System.Collections;

public class charactorMove : MonoBehaviour {

	public CharacterController m_Cc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//m_Cc.SimpleMove (new Vector3(1.0f, 0.0f, 0.0f));
		m_Cc.Move (Time.deltaTime * new Vector3(1.0f, -9.8f, 0.0f));
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.green; //換色
		Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.forward * 5.0f); //畫出正面線
		Gizmos.DrawWireSphere(this.transform.position, 3.0f); //畫出球狀
	}
}
