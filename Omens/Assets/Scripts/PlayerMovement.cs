using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    //Change the slope limit, and step offset in the inspector to handle steps and slopes!
    public float speed = 12f;
    public float gravity = -9.81f;

    //deals with the GroundCheck child on this game object, to deal with.. checking if it
    //is grounded or not. Useful for jumps, velocity reset, etc. 
    public Transform groundCheck;
    public float groundDistance = 0.4f;

    public float jumpHeight = 3f;
    public LayerMask groundMask;

    Vector3 velocity;

    //Good old grounded bool! You know this
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //This line deals with grounding. Uses the position of the sphere, the distance is the
        //radius, and mask as the layer mask (Tags & Layers -> Layers system. So mark it
        //as ground!!
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //This is for LOCAL movement and not Global, thank frick.
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
        //Physics equation for gravity. To determine velocity added. And yes, Sqrt is square root
        //good lord I am HORRIFIC AT MATH
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //handles velocity, related to adding gravity
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
    }
}
