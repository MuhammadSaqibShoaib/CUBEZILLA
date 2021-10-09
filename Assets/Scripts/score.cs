using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public Text scoreText;
    public static float ScoreVar= 0f;
    public void UpdateScore()
    {
        ScoreVar += 5f;
        scoreText.text = ScoreVar.ToString("0");

    }
    public void RestartScore()
    {
        ScoreVar = 0f;
    }
}
