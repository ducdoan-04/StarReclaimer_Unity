using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject instructionsPanel;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void NewGame(){
        SceneManager.LoadScene("GameplayLV1");
    }
    public void NextLevel(){
        SceneManager.LoadScene("GameplayLV2");
    }

    public void NextLevel3(){
        SceneManager.LoadScene("GameplayLV3");
    }

    public void QuitGame(){
        Application.Quit();
    }
    
    public void OnInstructionsButton()
    {
        if (instructionsPanel) instructionsPanel.SetActive(true);
    }

    public void OnCloseInstructions()
    {
        if (instructionsPanel) instructionsPanel.SetActive(false);
    }
}
