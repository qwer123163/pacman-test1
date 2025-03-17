using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenAboutthegame()
    {
        SceneManager.LoadScene("About the game");
    }
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void OpenExit()
    {
        SceneManager.LoadScene("Exit");
    }
    public void OpenGameover()
    {
        SceneManager.LoadScene("Game over");
    }
}