using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gamecanvas;
    [HideInInspector]
    public jump c;
       
    public void Start(){
       
        gamecanvas.SetActive(false);
        Time.timeScale = 1;
        
    }

    public void GameOver(){
        jump.death = true;
        FindObjectOfType<audiomanager>().play("Dead");
        gamecanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(1);
    }

    public void mainmenu(){
        SceneManager.LoadScene(0);
    }
}
