using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text MyscoreText;
    
    public static int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
        
    }

    // Update is called once per frame
    void Update()
    {
        MyscoreText.text = "Score : " + Mathf.Round (ScoreNum);
    }
}
