using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroManager : MonoBehaviour
{
    [Header("UI References")]
    public TextMeshProUGUI introText;
    public GameObject logo; // <-- thêm dòng này

    [Header("Story Lines")]
    [TextArea(2, 5)]
    public string[] storyLines;

    [Header("Timing (giây)")]
    public float fadeDuration = 0.8f;
    public float holdDuration = 1f;

    [Header("Next Scene")]
    public string nextSceneName = "MainMenu";

    [Header("Audio (optional)")]
    public AudioSource bgm;
    public float musicFadeTime = 1f;

    void Start()
    {
        // Tắt logo lúc đầu
        if (logo) logo.SetActive(false);

        // Phát nhạc
        if (bgm) bgm.Play();

        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {
        if (!introText) introText = FindObjectOfType<TextMeshProUGUI>();

        foreach (var line in storyLines)
        {
            yield return StartCoroutine(FadeLine(line));
        }

        if (bgm) yield return StartCoroutine(FadeOutMusic());

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextSceneName);
    }

    IEnumerator FadeOutMusic()
    {
        float start = bgm.volume;
        float t = 0f;
        while (t < musicFadeTime)
        {
            t += Time.deltaTime;
            bgm.volume = Mathf.Lerp(start, 0f, t / musicFadeTime);
            yield return null;
        }
        bgm.Stop();
        bgm.volume = start;
    }

    IEnumerator FadeLine(string text)
    {
        introText.text = text;
        Color c = introText.color;

        // Fade In
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            float a = t / fadeDuration;
            introText.color = new Color(c.r, c.g, c.b, a);
            yield return null;
        }

        introText.color = new Color(c.r, c.g, c.b, 1);
        yield return new WaitForSeconds(holdDuration);

        // Fade Out
        for (float t = fadeDuration; t > 0; t -= Time.deltaTime)
        {
            float a = t / fadeDuration;
            introText.color = new Color(c.r, c.g, c.b, a);
            yield return null;
        }

        introText.color = new Color(c.r, c.g, c.b, 0);

        // Hiện logo khi tới dòng chứa chữ "SPACE WARRIOR"
    if (text.ToUpper().Contains("SPACE WARRIOR"))
        {
            if (logo) logo.SetActive(true);
            FindObjectOfType<IntroLightPulse>()?.StartGlow();   // 🔥 gọi hiệu ứng sáng
        }
    }
}
