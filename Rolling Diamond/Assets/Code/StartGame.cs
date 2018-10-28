using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public void Start(string firstScene)
    {
        SceneManager.LoadScene(firstScene);
    }
    public void QuitScene()
    {
        Application.Quit();
    }
}
