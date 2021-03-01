using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs : MonoBehaviour
{
    
    public int highScore = 0;
    string highScoreKey = "";
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreAdd.score>highScore){
             PlayerPrefs.SetInt(highScoreKey, ScoreAdd.score);
             PlayerPrefs.Save();
             highScore = ScoreAdd.score;
             GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();
         }
         GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();
    }
}
