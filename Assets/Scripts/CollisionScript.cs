using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Player_Movement movement;
    private void OnCollisionEnter(Collision obj)
    {
        if(obj.collider.tag == "obstacl")
        {
            movement.enabled = false;
            FindObjectOfType<GameOver>().GameEnd();
            FindObjectOfType<AudioManager>().PlaySound("PlayerDeath");
        }
        if(obj.collider.tag == "coin")
        {
            FindObjectOfType<score>().UpdateScore();
            obj.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().PlaySound("coin");
        }
    }

}
