using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D _rgdBody;

    private float _movSpeedHor;
    private float _movSpeedVer;

    private float _inputHorizontal;
    private float _inputVertical;

    // Start is called before the first frame update
    private void Start()
    {
        _rgdBody = GetComponent<Rigidbody2D>();
        _movSpeedHor = 14f;
        _movSpeedVer = 41f;

    }

    // Update is called once per frame
    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        _inputVertical = Input.GetAxisRaw("Vertical");

        if (_inputHorizontal != 0)
        {
            _rgdBody.AddForce(new Vector2(_inputHorizontal * _movSpeedHor, 0f));
        }

        if (_inputVertical != 0)
        {
            _rgdBody.AddForce(new Vector2(0f, _inputVertical * _movSpeedVer));
        }

    }
}
