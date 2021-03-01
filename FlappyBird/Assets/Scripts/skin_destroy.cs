using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skin_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(choose.g==0){
            Destroy(gameObject);
        }   
    }

}
