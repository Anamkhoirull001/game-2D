using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverChecker : MonoBehaviour
{
    public GameObject m_gameOver;
    private bool m_isOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("game over");
        if(other.gameObject.CompareTag("enemy"))
        {
            if(m_isOver == false)
            {
                m_isOver = true;
                m_gameOver.SetActive (true);
                StartCoroutine("restartGame");
            }
        }
        Destroy (other.gameObject);
    }

    private IEnumerator restartGame()
    {
        yield return new WaitForSeconds (5.0f);

        Application.LoadLevel ("praktikum computer gaming");
        yield return null;
    }

}