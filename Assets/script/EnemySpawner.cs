using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public Transform m_top;
	public Transform m_bot;
	public GameObject m_enemy;

	// Use this for initialization
	void Start () {
		StartCoroutine("make");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator make(){
		while (true){
			yield return new WaitForSeconds(1.0f);
			GameObject enemy = Instantiate(m_enemy) as GameObject;

			enemy.transform.position = new Vector2 (
				m_top.transform.position.x, 
				Random.Range(m_top.transform.position.y,
				m_bot.transform.position.y));
		}
	}
}
