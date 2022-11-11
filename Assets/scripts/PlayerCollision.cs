using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "door-1")
        {

            GameObject go = GameObject.Find("door-1");
            go.SetActive(false);
        }
        else if (collision.gameObject.name == "door-2")
        {

            GameObject go = GameObject.Find("door-2");
            go.SetActive(false);
        }
        else if (collision.gameObject.name == "door-3")
        {

            GameObject go = GameObject.Find("door-3");
            go.SetActive(false);
        }
        else if (collision.gameObject.name == "door-4")
        {

            GameObject go = GameObject.Find("door-4");
            go.SetActive(false);
        }
        else if (collision.gameObject.name == "door-5")
        {

            GameObject go = GameObject.Find("door-5");
            go.SetActive(false);
        }
    }
}
