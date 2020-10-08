using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{


    //The position of the player's finger
    private Vector3 fingerPosition;

    //A reference to our rigid body 2d on our ship
    private Rigidbody2D rb;

    public BulletManager bulletManager;


    private void Start()
    {
        //On start, get a reference to the rigid body component
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        _FireBullet();

    }

    private void FixedUpdate()
    {

        //If there is no touch input, do not run the code.
        if(Input.touchCount > 0)
        {

            //Create Unity Touch object
            Touch touch = Input.GetTouch(0);

            //Link the vector 3 of the finger's position on our screen to our previously made Vector 3
            fingerPosition = Camera.main.ScreenToWorldPoint(touch.position);

            //Ensure we tell our game that the finger cannot move on the Z axis to prevent any depth bugs
            fingerPosition.z = 0;


           //Place our ship where the finger is (I could make the ship
            rb.position = fingerPosition;

            //If a finger is no longer on the screen, run this code
            if(touch.phase == TouchPhase.Ended)
            {

                //If the player no longer touches the screen, stop the ship.
                rb.velocity = Vector2.zero;
            }
        }



        //if(rb.position.x)
    }

    //Previous movement, will be deleted later
    //void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");
    //    Vector2 movement = new Vector2(moveHorizontal, moveVertical);

    //    movement *= Time.deltaTime;
    //    movement *= speed;



    //    // rb2d.AddForce(movement);
    //    transform.Translate(movement);


    //}

    private void _FireBullet()
    {
        if (Input.touchCount > 0)
        {
            if (Time.frameCount % 40 == 0)
            {
                bulletManager.GetBullet(transform.position);
            }
        }
    }
    
}
