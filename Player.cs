using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {


    public int moveX = 0;

    public int moveY = 0;

    public float moveSpeed = 0.2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveX * moveSpeed, moveY * moveSpeed, 0);

        if (!isLocalPlayer)
        {
            return;
        }

        moveX = 0;
        moveY = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveX -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveX += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveY += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveY -= 1;
        }


    }

    public void FixedUpdate()
    {
        transform.Translate(moveX * moveSpeed, moveY * moveSpeed, 0);
    }
}
