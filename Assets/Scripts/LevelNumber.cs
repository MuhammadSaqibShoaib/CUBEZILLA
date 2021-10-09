using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelNumber : MonoBehaviour
{
    public Text levelText;
    private void Update()
    {
        levelText.text = SceneManager.GetActiveScene().name;
    }
}
