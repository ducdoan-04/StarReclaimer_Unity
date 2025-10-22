using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LogoFade : MonoBehaviour
{
    public Image logoImage;
    public float fadeTime = 1f;

    void OnEnable() => StartCoroutine(FadeIn());

    IEnumerator FadeIn()
    {
        if (!logoImage) logoImage = GetComponent<Image>();
        Color c = logoImage.color;

        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            float alpha = t / fadeTime;
            logoImage.color = new Color(c.r, c.g, c.b, alpha);
            yield return null;
        }

        logoImage.color = new Color(c.r, c.g, c.b, 1);
    }
}
