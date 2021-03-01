using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jump.flag==true){
         if(ScoreAdd.score < 20 || (ScoreAdd.score < 60&& ScoreAdd.score > 40)|| (ScoreAdd.score > 80 )){   
        transform.position += Vector3.left * speed *  Time.deltaTime;
         }else{
             transform.position += Vector3.left * 5.5f *  Time.deltaTime;
         }
        }
    }
}
