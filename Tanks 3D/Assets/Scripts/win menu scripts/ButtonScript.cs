using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    
    public void LoadScene()
    {
        if (gameObject.name == "BackToMenu")
        {
            GameObject.Find("SoundGlobal").GetComponent<AudioSource>().Play();
            SceneManager.LoadScene(0);
        }        
        else if(gameObject.name == "NextLVL" && SelectLVL.lvlID<10)
        {
            
            SceneManager.LoadScene(SelectLVL.lvlID + 1);
            SelectLVL.lvlID++;
            print("Следующий лвл - " + SelectLVL.lvlID);
        }
                
    }
}
