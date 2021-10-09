using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneScript : MonoBehaviour
{
    //public GameOver over;
    public void onPressRestart()
    {
        score.ScoreVar = 0f;
        SceneManager.LoadScene("First Scene");
    }
    public void onPressStart()
    {
        score.ScoreVar = 0f;
        SceneManager.LoadScene("Level 1");
    }
    public void onPressedQuit()
    {
        Application.Quit();
    }

}
