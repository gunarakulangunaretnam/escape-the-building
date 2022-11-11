using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rgdBody;
    // Start is called before the first frame update
    private void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        float directX = Input.GetAxisRaw("Horizontal");
        rgdBody.velocity = new Vector2(directX * 7f, rgdBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rgdBody.velocity = new Vector2(rgdBody.velocity.x, 14f);

        }
    }
}
