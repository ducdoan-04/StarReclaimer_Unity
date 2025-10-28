using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject instructionsPanel;

    [Header("Audio (optional)")]
    public AudioSource bgm;
    public AudioSource clickSound;

    void Start()
    {
        // Tắt panel hướng dẫn lúc đầu
        if (instructionsPanel) instructionsPanel.SetActive(false);

        // Bật nhạc nền
        if (bgm) bgm.Play();
    }

    // Hàm phát âm thanh click
    void PlayClickSound()
    {
        if (clickSound != null)
        {
            clickSound.Stop();
            clickSound.Play();
        }
    }

    // Khi bấm Play
    public void OnPlayButton()
    {
        if (clickSound) clickSound.Play();
        // SceneManager.LoadScene("Gameplay");
        FindObjectOfType<SceneFader>()?.FadeToScene("Gameplay");
    }

    // Khi bấm Instructions
    public void OnInstructionsButton()
    {
        if (clickSound) clickSound.Play();
        if (instructionsPanel) instructionsPanel.SetActive(true);
    }

    // Khi bấm Close trong panel
    public void OnCloseInstructions()
    {
        if (clickSound) clickSound.Play();
        if (instructionsPanel) instructionsPanel.SetActive(false);
    }

    // Khi bấm Quit
    public void OnQuitButton()
    {
        if (clickSound) clickSound.Play();
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
