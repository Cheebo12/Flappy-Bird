using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float gravity = 10f;
    private float NewVelocity;
    private Vector2 moveDirection;
    public float y;
    
    
    Vector2 movespot;
    public GameManager gamemanager;
    public float grav = -20f;
    float v;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
            
    }

    // Update is called once per frame
    void Update()
    {
       
        movespot.x = transform.position.x;
     
       if(Input.GetKeyDown(KeyCode.Space)){
                
          v = 5f;
         }

         for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
            v = 5f;
            }
        }
          v = v + grav*Time.deltaTime;
       
          y = transform.position.y + v*Time.deltaTime;

           movespot.y = y;

           transform.position = Vector2.MoveTowards(transform.position,movespot, gravity*Time.deltaTime);
         
    }
    public void OnCollisionEnter2D(Collision2D collision){
        
           gamemanager.GameOver();
        
       
    }
}
