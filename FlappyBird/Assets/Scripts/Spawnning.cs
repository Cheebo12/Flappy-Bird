using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnning : MonoBehaviour
{   private float timer = 0;
    private float maxtime = 1.2f;
    public GameObject Pillars;
    
    public float height;
 
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if(timer > maxtime && jump.flag == true){
                  y = Random.Range(5.80f, 1.79f); 
        GameObject newpillar = Instantiate(Pillars);

        newpillar.transform.position = transform.position + new Vector3(0,y,0);
       
        timer = 0;
        Destroy(newpillar, 8);
        
       
 }   if(jump.flag == true){
        timer += Time.deltaTime;
 }
    }
    
    
    
}
