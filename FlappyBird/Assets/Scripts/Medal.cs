using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Medal : MonoBehaviour
{
    public Image gold;
    public Image silver;
    // Start is called before the first frame update
    void Start()
    {
        gold.enabled = false;
        silver.enabled = false;
        if(ScoreAdd.score > 50){
         gold.enabled = true;
        }else{
            silver.enabled = true;
        }
    }
}
