using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGlobal : MonoBehaviour
{
    static private GameObject firstInstance = null;

    void Start()
    {
        if (firstInstance == null)
        {
            firstInstance = gameObject;
            DontDestroyOnLoad(gameObject);
        }

        else if (gameObject != firstInstance)
        {
            Destroy(gameObject);
        }

    }
}
