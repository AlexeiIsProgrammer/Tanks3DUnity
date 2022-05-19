using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffMusic : MonoBehaviour
{
    // Start is called before the first frame update
    static private GameObject firstInstance = null;

    [SerializeField] public Sprite icon1;
    [SerializeField] public Sprite icon2;
    private bool prov = false;

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
    public void musikPlay()
    {
        AudioSource auClick = GameObject.Find("SoundClickGlobal").GetComponent<AudioSource>();
        auClick.Play();
        AudioSource auGlobal = GameObject.Find("SoundGlobal").GetComponent<AudioSource>();
        if (prov)
        {
            this.GetComponent<Image>().sprite = icon1;
            auGlobal.Play();
            prov = !prov;
        }
        else
        {
            this.GetComponent<Image>().sprite = icon2;
            auGlobal.Stop();
            prov = !prov;
        }
    }
}
