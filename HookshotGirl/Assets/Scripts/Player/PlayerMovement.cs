using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool canMove;
    public bool canJump;

    [ShowOnly] public bool isMoving;
    [ShowOnly] public bool isJumping;

    public float moveSpeed;

    public Vector2 deltaMovement; 

    // Start is called before the first frame update
    public void Initialize()
    {

    }

    // Update is called once per frame
    public void Tick()
    {
        deltaMovement = Vector2.zero;

        //Check Horizontal movement
        if(canMove && Input.GetAxis("Horizontal") != 0f)
        {
            //Adjust DeltaMovement
            isMoving = true;
            deltaMovement.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        }
        else
        {
            isMoving = false;
        }

        //Check Jumping
        //*TBD*

        //Move character according to delta
        transform.position += (Vector3)deltaMovement;
    }
}
