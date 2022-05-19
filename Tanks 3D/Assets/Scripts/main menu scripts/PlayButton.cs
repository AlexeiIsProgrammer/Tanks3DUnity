
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    
    public void LoadScene()
    {
        if (gameObject.name == "PlayButton")
            SceneManager.LoadScene(13);
        else if (gameObject.name == "Settings")
            SceneManager.LoadScene(11);
        else if (gameObject.name == "Statistics")
            SceneManager.LoadScene(12);
    }
}
