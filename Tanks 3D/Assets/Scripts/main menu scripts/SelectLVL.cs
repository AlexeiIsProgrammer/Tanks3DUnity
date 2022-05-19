
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectLVL : MonoBehaviour
{
    static public int lvlID=1;
    public void LoadScene()
    {
        GameObject.Find("SoundGlobal").GetComponent<AudioSource>().Stop();
        for (int i=1;i<=10;i++)
        {
            if(gameObject.name == i+" lvl")
            {
                lvlID = i;
                SceneManager.LoadScene(i);
                
                break;
            }
        }
    }
}
