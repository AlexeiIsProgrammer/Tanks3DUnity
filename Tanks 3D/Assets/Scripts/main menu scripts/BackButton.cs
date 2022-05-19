using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
