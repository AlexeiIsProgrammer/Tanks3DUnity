using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Threading;
public class Timer : MonoBehaviour
{
    Stopwatch stopWatch = new Stopwatch();
    public GameObject bullet;
   
    void Start()
    {
        //NewBehaviourScript beh = GameObject.Find("ScriptHolder").GetComponent(typeof(NewBehaviourScript));
        bullet = GetComponent<GameObject>();
        bool gm = bullet;
        stopWatch.Start();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);        
    }
}
