using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTrigger : MonoBehaviour
{
    [SerializeField] private Image testImage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            testImage.enabled = true;
        }
    }
}
