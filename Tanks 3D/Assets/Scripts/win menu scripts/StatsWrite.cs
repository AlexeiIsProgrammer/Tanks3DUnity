using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class StatsWrite : MonoBehaviour
{

    private void Start()
    {
        string[] mas = File.ReadAllLines("lvl Stat.txt");
        GameObject.Find("���������").GetComponent<Text>().text = mas[1];
        GameObject.Find("���������").GetComponent<Text>().text = mas[0];
    }
}
