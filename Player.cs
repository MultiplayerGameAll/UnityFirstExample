using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class Player : NetworkBehaviour {

    public int moveX = 0;
    public int moveY = 0;
    public float moveSpeed = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }

        // input handling for local player only
        int oldMoveX = moveX;
        int oldMoveY = moveY;

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
        if (moveX != oldMoveX || moveY != oldMoveY)
        {
            CmdMove(moveX, moveY);
        }
	
	}

	[Command]
    public void CmdMove(int x, int y)
    {
        moveX = x;
        moveY = y;
        transform.Translate(moveX * moveSpeed, moveY * moveSpeed, 0);
        base.SetDirtyBit(1);
    }
	
    [ServerCallback]
    public void FixedUpdate()
    {
        transform.Translate(moveX * moveSpeed, moveY * moveSpeed, 0);
    }
	
	
}
