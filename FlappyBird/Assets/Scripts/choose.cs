using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choose : MonoBehaviour
{ 
 public GameObject gamecanvas;

 public static int g = 0;
 public static int gg = 0;
 public static int ggg = 0;

void start(){
    g=0;
    gg=0;
    ggg=0;    
}
public void selectyellow(){
   g = 1;
   gg=0;
   ggg=0;  
   SceneManager.LoadScene (sceneName:"start");
}

public void selectred(){
   gg = 1;
   g=0;
   ggg=0;
   SceneManager.LoadScene (sceneName:"start");
}

public void selectblue(){
   ggg = 1;
   g=0;
   gg=0;
   SceneManager.LoadScene (sceneName:"start");
}
}
