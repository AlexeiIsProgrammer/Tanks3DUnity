using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    private AudioSource au;
    public float musicVol = 1f;
    void Start()
    {
        au = GameObject.Find("SoundGlobal").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        au.volume = musicVol;
    }

    public void VolumeC(float val)
    {
        musicVol = val;
    }
}
