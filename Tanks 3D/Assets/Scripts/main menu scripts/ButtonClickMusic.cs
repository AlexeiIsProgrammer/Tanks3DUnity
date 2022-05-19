using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickMusic : MonoBehaviour
{
    AudioSource aud;
    // Start is called before the first frame update
    private void Start()
    {
        aud = GameObject.Find("SoundClickGlobal").GetComponent<AudioSource>();    
    }
    public void click()
    {
        aud.Play();
    }
}
