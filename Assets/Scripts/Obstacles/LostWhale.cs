using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LostWhale : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider){
        if (!collider.CompareTag("Player")) return;

        string current = SceneManager.GetActiveScene().name;
        if (current.EndsWith("Complete")) return; // tránh load lại nếu đang ở scene Complete

        string target = current + "Complete";

        if (SceneExistsInBuild(target)){
            SceneManager.LoadScene(target);
        } else {
            Debug.LogWarning($"Scene '{target}' not found in Build Settings. Loading fallback 'MainMenu'.");
            SceneManager.LoadScene("MainMenu");
        }
    }

    private bool SceneExistsInBuild(string sceneName){
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++){
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string name = Path.GetFileNameWithoutExtension(path);
            if (name == sceneName) return true;
        }
        return false;
    }
}

// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class LostWhale : MonoBehaviour
// {
//     private void OnTriggerEnter2D(Collider2D collider){
//         if (collider.gameObject.CompareTag("Player")){
//             SceneManager.LoadScene("GameplayLV1Complete");
//         }
//     }
// }