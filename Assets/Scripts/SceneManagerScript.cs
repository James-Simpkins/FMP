using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public string sceneName; // Declare sceneName as a public string variable, so that it can set to different scenes in Unity Editor.

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
