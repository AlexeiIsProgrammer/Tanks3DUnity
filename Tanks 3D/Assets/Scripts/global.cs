using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System;
public class global : MonoBehaviour
{
    
    public static TimeSpan ts;
    public static DateTime time;
    string[] mas = File.ReadAllLines("Stata.txt");
    //public static string elapsedTime;
    public static int tanks;
    Stopwatch stopWatch = new Stopwatch();

    private void OnApplicationQuit()
    {
        stopWatch.Stop();
        stopWatch.Reset();
        File.WriteAllText("Stata.txt", Convert.ToString(tanks) + "\n");
        File.AppendAllText("Stata.txt", time.Add(ts).ToLongTimeString());
        print(time.ToLongTimeString());
    }

    void Start()
    {
        DontDestroyOnLoad(this);
        stopWatch.Start();
        string[] mas = File.ReadAllLines("Stata.txt");
        tanks = Convert.ToInt32(mas[0]);
        time = Convert.ToDateTime(mas[1]);
        print("Сработано");
    }
    void FixedUpdate()
    {
        ts = stopWatch.Elapsed;
        //elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           //ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
