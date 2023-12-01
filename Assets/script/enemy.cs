using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public float m_mainSpeed = -0.001f;
	public float m_maxSpeed = -0.009f;
	public float m_speed = -0.0f;

	// Use this for initialization
	void Start () {
		m_speed = Random.Range (m_mainSpeed, m_maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2 (m_speed, 0));
	}
}
