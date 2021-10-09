using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameOver game;
    public Text level;
    private void OnTriggerEnter()
    {
        level.text = SceneManager.GetActiveScene().name;
        game.onGameWon();
        
    }
}
