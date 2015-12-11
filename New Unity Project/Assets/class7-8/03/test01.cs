using UnityEngine;
using System.Collections;

public class test01 : MonoBehaviour {

	public Camera m_cam;
	public GameObject m_cube;

	public delegate void FunctionDelegate(int x);
	public FunctionDelegate m_testDelegate = null;

	// Use this for initialization
	void Start () {
		m_testDelegate = delegateTest.doSomething;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray r = m_cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit rh;
			bool m_b = Physics.Raycast( r, out rh, 10000.0f,1 << LayerMask.NameToLayer("Terrain2") );
			if(m_b){
				/*
				//Debug.Log(rh.point);
				Vector3 v_dif =  rh.point - m_cube.transform.position;
				v_dif.y = 0;
				float dis = v_dif.magnitude;
				if(dis<0.1f){
					m_cube.transform.position = new Vector3( rh.point.x, m_cube.transform.position.y, rh.point.z);
				}else{
					v_dif.Normalize();
					m_cube.transform.forward = v_dif;
					m_cube.transform.position = m_cube.transform.position + m_cube.transform.forward*0.1f;
				}


				GameObject go = rh.collider.gameObject;
				Destroy(go);
				go = null;


				GameObject go = rh.collider.gameObject;
				go.SetActive( false );*/
			}
			m_testDelegate(100);
		}
		/*
		if (Input.GetMouseButtonDown (0)) {
			//GameObject o = GameObject.Find("Main Camera");
			//Debug.Log(o);
			//Camera m_cam = o.GetComponent<Camera>();

			//GameObject o = GameObject.FindGameObjectWithTag("MainCamera");
			//Debug.Log(o.name);

			GameObject [] players = GameObject.FindGameObjectsWithTag("Player");
			foreach(GameObject go in players){
				Debug.Log(go.name);
			}
		}*/
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.green; //換色
		Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.forward * 5.0f); //畫出正面線
		Gizmos.DrawWireSphere(this.transform.position, 3.0f); //畫出球狀
	}
}
