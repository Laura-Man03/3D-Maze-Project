using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 4.5f; //use f as a unit in floats for a point value
    public float jumpForce = 5;
    public string hero = "Steve"; 
    
    public Vector3 direction; //XYZ coords
    public Rigidbody playerRb; //Connecting a rigidbody
    void Start()
    {
        Debug.Log("My name is " + hero);
       
    }
//physics loop
    void FixedUpdate()
    {
            //the . is there to access the function of transform
        //rigidbody is the proper way to connect movement with physics
        Vector3 velocity = direction * speed;
        velocity.y = playerRb.linearVelocity.y;

        playerRb.linearVelocity = velocity;
    }
    
    private void OnMove(InputValue value)
    {
        //Asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);
    }

    private void OnJump(InputValue value)
    {
        //physics.raycast will cast a line that can hit other colliders
        //if it finds a collider, it returns true if it doesn't, it returns false
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);
        if (isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}