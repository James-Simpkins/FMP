using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class ScoreManagerScript : MonoBehaviour
{
    public TMP_Text scoreText;
    private int scoreCount = 0;

    public void AddPoint()
    {
        scoreCount++; // Add a point to the score.
        scoreText.text = "Score: " + scoreCount.ToString(); // Set TestMeshPro to say 'Score: ', followed by the score.
    }
}
