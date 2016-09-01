﻿using UnityEngine;
using System.Collections;

public class Walk : GameObjectBehaviour
{
    public float Accel, MaxVelocity, Drag;
	// Use this for initialization
	void Start () {
        base.Start();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("right"))
        {
            body.AddForce(Vector2.right * Accel);

            if(body.velocity.x > MaxVelocity)
            {
                body.velocity = (Vector2.right * MaxVelocity) + (Vector2.up * body.velocity.y);
            }
        }else        
        if (Input.GetKey("left"))
        {
            body.AddForce(Vector2.left * Accel);

            if (body.velocity.x < -MaxVelocity)
            {
                body.velocity = (Vector2.left * MaxVelocity) + (Vector2.up * body.velocity.y);
            }
        }
        else{
            Debug.Log(body.velocity);
            if(body.velocity.magnitude > 0)
            {
                body.AddForce(Vector2.left * body.velocity.x * Drag);
            }
        }
    }
}
