using UnityEngine;

public class Quit: MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game will quit now!");
        Application.Quit();
    }
}