using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void QuitApp()
    {
        print("Выход");
        Application.Quit();
    }
}
