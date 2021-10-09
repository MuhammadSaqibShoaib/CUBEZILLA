using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    bool GameEnded = false;
    public GameObject LevelCompUI;
    public float RestartDelay = 1f;
    public void GameEnd()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            FindObjectOfType<score>().RestartScore();
            Invoke("RestartLevel", RestartDelay);
        }
    }

    public void onGameWon()
    {
        LevelCompUI.SetActive(true);
    }

    void RestartLevel()
    { 
        SceneManager.LoadScene("Level 1");
    }
  
}
