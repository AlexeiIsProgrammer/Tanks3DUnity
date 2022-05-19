using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingletonClass : MonoBehaviour
{
    

    static private GameObject firstInstance = null;

    void Start()
    {
        if (firstInstance == null)
        {
            print("Создан");
            gameObject.GetComponent<AudioSource>().Play();
            firstInstance = gameObject;
            DontDestroyOnLoad(gameObject);
        }    
            
        else if (gameObject != firstInstance)
        {
            Destroy(gameObject);
            print("Уничтожен");
        }
           
    }
}
