using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame() => SceneManager.LoadScene(1);
    public void LoadMainMenu() => SceneManager.LoadScene(0);
    public void ExitGame()
    {
        print("Ценок");
        Application.Quit();
    }
}
