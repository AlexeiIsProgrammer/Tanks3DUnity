using System;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class BaseOfSource : MonoBehaviour
{
   
    private void FixedUpdate()
    {
        GameObject.Find("ИнфаВремя1").GetComponent<Text>().text = global.time.Add(global.ts).ToLongTimeString();
        GameObject.Find("ИнфаТанки1").GetComponent<Text>().text = Convert.ToString(global.tanks);

        File.WriteAllText("Stata.txt", Convert.ToString(global.tanks) + "\n");
        File.AppendAllText("Stata.txt", global.time.Add(global.ts).ToLongTimeString());

    }

}
