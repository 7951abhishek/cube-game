using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public void Restart()
    {
       Invoke("Res", 1.0f);
    }
    void Res()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
