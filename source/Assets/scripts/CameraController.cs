using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float xOffset = 1;
    [SerializeField] private float yOffset = 1;
    [SerializeField] private Transform player;
    [SerializeField] private float FollowSpeed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 newPos = new Vector3(player.position.x + xOffset, player.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}
