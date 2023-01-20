using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        Debug.Log(collision.gameObject.tag);
        
        if (collision.gameObject.tag == "Player")
        {
           	Debug.Log("Logging Message to Console");
            GameObject go = GameObject.Find("door-1");
            go.SetActive(false);
            
        }
       
    }
}
