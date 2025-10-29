using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void NewGame(){
        SceneManager.LoadScene("GameplayLV1");
    }

    public void QuitGame(){
        Application.Quit();
    }

}
