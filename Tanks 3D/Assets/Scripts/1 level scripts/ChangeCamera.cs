using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    
    //public GameObject camera1;
    //public GameObject camera2;

    public Camera playercam1;
    public Camera playercam2;
    
    bool chenge = true;

    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
           if(chenge)
            {
                playercam2.enabled = true;
                playercam1.enabled = false;

                chenge = false;
            }
           else
            {
                playercam1.enabled = true;
                playercam2.enabled = false;

                chenge = true;
            }
        }
       
    }
}
