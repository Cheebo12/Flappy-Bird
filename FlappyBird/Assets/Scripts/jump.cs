using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float gravity;
    private float NewVelocity;
    private Vector2 moveDirection;
    public float y;
    [HideInInspector]
    public static bool death=false;
    
    Vector2 movespot;
    public GameManager gamemanager;
    public float grav;
    float v;
    public static bool flag = false;
    int[] ar = new int[2];
    Quaternion angle0 = Quaternion.Euler(0,0,0);
    Quaternion angle45 = Quaternion.Euler(0,0,60);
    public Quaternion current;
    // Start is called before the first frame update
    void Start()
    {
       current = angle0;
       death = false;  
       flag = false;   
    }

    // Update is called once per frame
    void Update()
    {
       if(flag){
        movespot.x = transform.position.x;
     
       if(Input.GetKeyDown(KeyCode.Space) && !death){
            FindObjectOfType<audiomanager>().play("BirdFlap");    
          v = 3f;
          current = angle45;
         }

         for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && !death)
            {
                FindObjectOfType<audiomanager>().play("BirdFlap");
                current = angle45;
            v = 5f;
           
            }
        }
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,current,0.2f);

          v = v + grav*Time.deltaTime;
       
       
       Debug.Log("v "+v);
          y = transform.position.y + v*Time.fixedDeltaTime;

           movespot.y = y;
           
           transform.position = Vector2.MoveTowards(transform.position,movespot, gravity*Time.deltaTime);
           
        Debug.Log("euler"+ this.transform.rotation.z);   
        if
        (this.transform.rotation.z > 0.37){
            current = angle0;
     //   transform.Rotate(Vector3.down* Time.deltaTime);
        
        }

           
    }else{
         movespot.x = transform.position.x;
     
       if(Input.GetKeyDown(KeyCode.Space) && !death){
            FindObjectOfType<audiomanager>().play("BirdFlap");    
          v = 3f;
          flag=true;
          current = angle45;
         }

         for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && !death)
            {
                FindObjectOfType<audiomanager>().play("BirdFlap");
            
            v = 5f;
            flag = true;
            current = angle45;
            }
        }
         // v = v + grav*Time.deltaTime;
       
          y = transform.position.y + v*Time.fixedDeltaTime;
         
           movespot.y = y;
          
           transform.position = Vector2.MoveTowards(transform.position,movespot, gravity*Time.deltaTime);
             this.transform.rotation = Quaternion.Slerp(this.transform.rotation,current,0.2f);
        if(this.transform.rotation.z == 45){
            
            current = angle0;
      //  this.transform.rotation = Quaternion.Slerp(this.transform.rotation,current,0.2f);
        }
        
        }
    }
    public void OnCollisionEnter2D(Collision2D collision){
              
           gamemanager.GameOver();
        
       
    }
}
