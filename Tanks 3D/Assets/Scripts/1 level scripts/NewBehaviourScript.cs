using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System;
public class NewBehaviourScript : MonoBehaviour
{
    public static int tanksKills = 0;
    public static bool tankBool = false;
    Stopwatch stopWatch = new Stopwatch();

    private void Start()
    {
        stopWatch.Start();
        tanksKills = 0;
    }
    public void WriteInFile()
    {
        //time.gameOver = false;
        print(stopWatch.Elapsed);
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        stopWatch.Reset();
        string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
             ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        print(elapsedTime);
        
        
        File.WriteAllText("lvl Stat.txt", Convert.ToString(tanksKills) + "\n");
        File.AppendAllText("lvl Stat.txt", elapsedTime);

        global.tanks += tanksKills;

        
        File.WriteAllText("Stata.txt", Convert.ToString(global.tanks)+"\n");
        File.AppendAllText("Stata.txt", global.time.Add(global.ts).ToLongTimeString());

    }
    public static void WinBlock()
    {
        if (NewBehaviourScript.tankBool)
        {
            NewBehaviourScript.tankBool = false;
            Collisi.Copy();
            SceneManager.LoadScene(15);
        }
    }
}
