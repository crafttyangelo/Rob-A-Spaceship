using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private string gameScene = "Rob A Spaceship";

    public void PlayGame()
    {
        SceneManager.LoadScene(gameScene);
    }
}
