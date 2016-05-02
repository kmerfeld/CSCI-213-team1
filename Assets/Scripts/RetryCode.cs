using UnityEngine;
using System.Collections;

public class RetryCode : MonoBehaviour {

    static string lastScene;
    static string currentScene;

    void Awake()
    {
        DontDestroyOnLoad(this.transform.gameObject);
    }

    public static void ChangeScene(string sceneName)
    {
        lastScene = currentScene;
        currentScene = sceneName;
        Application.LoadLevel(currentScene);
    }

    public static void LoadLastScene()
    {
        string last = lastScene;
        lastScene = currentScene;
        currentScene = last;
        Application.LoadLevel(currentScene);
    }
}
