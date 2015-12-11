using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Create ballet dynamically with left mouse key
		// Input.GetMouseButtonDown(0)//left
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Ray r = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
			RaycastHit rh;
			bool m_b = Physics.Raycast (r, out rh, 10000.0f, 1 << LayerMask.NameToLayer ("Terrain"));
			if (m_b) {
				GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				sphere.transform.position = this.transform.position;
				Vector3 v_dif = rh.point - this.transform.position;
				v_dif.Normalize();
				Rigidbody m_rigid = sphere.AddComponent<Rigidbody>();
				m_rigid.useGravity = false;
				m_rigid.velocity = v_dif*100;
			}
		}
	}
}
