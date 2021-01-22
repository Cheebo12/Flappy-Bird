using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    private float NewVelocity;
    
    public float InitialVelocity = 5f;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        NewVelocity = InitialVelocity - 10*Time.deltaTime;
                                           
        y = NewVelocity*Time.deltaTime;
       
       if(Input.GetKeyDown(KeyCode.Space)){
                
         }
        
       
    }
}
