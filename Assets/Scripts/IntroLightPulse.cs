using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class IntroLightPulse : MonoBehaviour
{
    public Light2D introLight;     // Gán Light2D vào đây
    public float startIntensity = 0.3f;
    public float targetIntensity = 2.0f;
    public float duration = 1.5f;

    void Awake()
    {
        if (!introLight) introLight = GetComponent<Light2D>();
        introLight.intensity = startIntensity;
    }

    public void StartGlow()
    {
        StartCoroutine(GlowEffect());
    }

    IEnumerator GlowEffect()
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            introLight.intensity = Mathf.Lerp(startIntensity, targetIntensity, elapsed / duration);
            yield return null;
        }

        introLight.intensity = targetIntensity;
    }
}
