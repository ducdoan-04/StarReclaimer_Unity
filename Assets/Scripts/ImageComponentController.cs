using UnityEngine;
using UnityEngine.UI;

public class ImageComponentController : MonoBehaviour
{
    public Image myImageComponent; // Assign your Image component in the Inspector

    void Start()
    {
        // Disable the Image component at the start
        myImageComponent.enabled = false;
    }

    // Example function to enable the Image component later
    public void ShowImageComponent()
    {
        myImageComponent.enabled = true;
    }

    // Example function to disable the Image component again
    public void HideImageComponent()
    {
        myImageComponent.enabled = false;
    }
}