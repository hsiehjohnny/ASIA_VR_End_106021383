using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontrol : MonoBehaviour
{
    public void RestartGame() 
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitGame() 
    {
        Application.Quit();
    }
}
