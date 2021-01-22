using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gamecanvas;

    
    public void Start(){
        gamecanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver(){
        gamecanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }
}
