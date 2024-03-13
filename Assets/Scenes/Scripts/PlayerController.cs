using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // movement variables
    //[SerializeField] Rigidbody2D rbody; 
    //private float horizInput;
    //private float moveSpeed = 450.0f;  // 4.5 * 100 since we're using Rigidbody physics to move

    // jump variables
    //private float jumpHeight = 3.0f;
    //private float jumpTime = 0.75f;
    //private float initialJumpVelocity;


    // Start is called before the first frame update
    void Start()
    {
        // given a desired jumpHeight and jumpTime, calculate gravity (same formulas as 3D)
        //float timeToApex = jumpTime / 2.0f;
        //float gravity = (-2 * jumpHeight) / Mathf.Pow(timeToApex, 2);

        // calculate jump velocity (upward motion)
        //initialJumpVelocity = Mathf.Sqrt(jumpHeight * -2 * gravity);      
    }

    // Update is called once per frame
    void Update()
    {
        // read (and store) horizontal input
        //horizInput = Input.GetAxis("Horizontal");        
    }

    private void FixedUpdate()
    {
        // We're moving via Rigidbody physics (setting velocity directly) so we need to use FixedUpdate
        //float xVel = horizInput * moveSpeed * Time.deltaTime;   // determine x velocity
        //rbody.velocity = new Vector2(xVel, rbody.velocity.y);   // set new x velocity, maintain existing y velocity
    }
}
