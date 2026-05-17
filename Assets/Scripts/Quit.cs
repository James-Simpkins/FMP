using UnityEngine;

public class Quit: MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game will quit now!"); // Says the game will quit in console, as 'Application.Quit' does nothing in Unity Editor.
        Application.Quit(); // Quits the game.
    }
}