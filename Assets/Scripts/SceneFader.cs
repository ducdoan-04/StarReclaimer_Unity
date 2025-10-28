using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFader : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1f;

    void Start()
    {
        if (fadeImage != null)
        {
            fadeImage.gameObject.SetActive(true);
            StartCoroutine(FadeIn());
        }
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName));
    }

    IEnumerator FadeIn()
    {
        Color c = fadeImage.color;
        for (float t = fadeDuration; t > 0; t -= Time.deltaTime)
        {
            c.a = t / fadeDuration;
            fadeImage.color = c;
            yield return null;
        }
        c.a = 0;
        fadeImage.color = c;
    }

    IEnumerator FadeOut(string sceneName)
    {
        Color c = fadeImage.color;
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            c.a = t / fadeDuration;
            fadeImage.color = c;
            yield return null;
        }
        c.a = 1;
        fadeImage.color = c;

        SceneManager.LoadScene(sceneName);
    }
}
