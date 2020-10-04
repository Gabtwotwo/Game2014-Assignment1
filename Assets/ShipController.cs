using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{


    private Vector3 fingerPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float speed = 10.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            fingerPosition = Camera.main.ScreenToWorldPoint(touch.position);
            fingerPosition.z = 0;
            direction = (fingerPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y)*speed;
            if(touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }

        //if(rb.position.x)
    }

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
}
