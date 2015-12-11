using UnityEngine;
using System.Collections;

public class m_hit : MonoBehaviour {

	public GameObject m_this;
	public Collider m_collider;

	// Use this for initialization
	void Start () {
		m_collider.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		//Debug.Log ("HHHH");
		Destroy(other.gameObject);
		m_this.SetActive (false);
	}
}
