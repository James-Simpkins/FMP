using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string sceneName;

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
