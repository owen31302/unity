using UnityEngine;
using System.Collections;

public class m_cam : MonoBehaviour {

	public Camera m_camera;
	public Transform parentTrans;

	// Use this for initialization
	void Start () {
		//Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		float mouseY = Input.GetAxis ("Mouse X");
		float mouseX = Input.GetAxis ("Mouse Y");
		//Debug.Log ("MouseX: "+ mouseX + " Mouse Y: " + mouseY);

		//Debug.Log ("eulerAngles.x: " + m_camera.transform.eulerAngles.x);
		//Debug.Log ("mouseX: " + mouseX);
		if (m_camera.transform.eulerAngles.x >= 0 & m_camera.transform.eulerAngles.x < 90  | 
		    m_camera.transform.eulerAngles.x > 270  & m_camera.transform.eulerAngles.x < 360) {
			if(m_camera.transform.eulerAngles.x - mouseX > 275 |
			   m_camera.transform.eulerAngles.x - mouseX < 85){
				m_camera.transform.Rotate (-mouseX, 0.0f, 0.0f, Space.Self);
				//Debug.Log ("1 eulerAngles.x: " + m_camera.transform.eulerAngles.x);
			}
		}

		parentTrans.transform.Rotate(0.0f, mouseY, 0.0f, Space.World);
	}
}
