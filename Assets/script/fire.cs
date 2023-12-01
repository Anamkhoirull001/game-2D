using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	public float m_speed = 0.3f; // f (frame/secont)
	void Start(){
		Destroy (gameObject, 3.0f);
	}

	void Update (){
		transform.position += transform.right * m_speed;
	}

	void OnTriggerEnter2D (Collider2D other)
	{
        if(other.gameObject.CompareTag("enemy"))
		// if(other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			ScoreManager.ScoreNum += 1;
		}
	}
}