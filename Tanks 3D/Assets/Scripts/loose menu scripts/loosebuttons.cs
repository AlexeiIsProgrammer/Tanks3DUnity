using UnityEngine;
using UnityEngine.SceneManagement;
public class loosebuttons : MonoBehaviour
{
    public void LoadScene()
    {
        if (gameObject.name == "BackToMenu")
        { 
            GameObject.Find("SoundGlobal").GetComponent<AudioSource>().Play();
            SceneManager.LoadScene(0);
        }
            
        else if (gameObject.name == "ReloadLVL")
            SceneManager.LoadScene(SelectLVL.lvlID);
    }
}
