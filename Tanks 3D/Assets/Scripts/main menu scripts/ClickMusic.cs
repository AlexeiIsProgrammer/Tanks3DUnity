using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMusic : MonoBehaviour
{
    // Start is called before the first frame update
    static private GameObject firstInstance = null;

    void Start()
    {
        if (firstInstance == null)
        {
            print("Создан");
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
