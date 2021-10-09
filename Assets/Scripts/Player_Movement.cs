using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed = 1000f;
    public float sidewaysSpeed = 600f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y < 0f)
        { 
        
            FindObjectOfType<GameOver>().GameEnd();
        }
    }
}
