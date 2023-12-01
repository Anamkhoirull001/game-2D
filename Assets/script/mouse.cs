using System.Collections;
using UnityEngine;

public class mouse : MonoBehaviour {

	public GameObject m_fire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			fire();
		}
	}

	private void fire(){
		Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		GameObject fire = Instantiate (m_fire) as GameObject;
		fire.transform.position = transform.position;

		float rad = Mathf.Atan2 (mouse.y - transform.position.y, mouse.x - transform.position.x);
		fire.transform.Rotate(new Vector3(0,0, Mathf.Rad2Deg * rad));
	}
}
