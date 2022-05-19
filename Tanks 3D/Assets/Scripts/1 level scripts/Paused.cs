using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    bool prov = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(prov)
            {
                prov = false;
                Time.timeScale = 0;
            }
            else
            {
                prov = true;
                Time.timeScale = 1;
            }
            
        }
        
    }
}
