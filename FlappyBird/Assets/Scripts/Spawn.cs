using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{   private float timer = 0;
    private float maxtime = 1;
    public GameObject coinclone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
     {if(timer > maxtime){
        
        GameObject CoinClone = Instantiate(coinclone);
        
        

        
        
        }
        timer += Time.deltaTime;
    }
}
