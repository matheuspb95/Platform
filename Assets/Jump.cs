using UnityEngine;
using System.Collections;

public class Jump : GameObjectBehaviour {
    float PressedTime;
    public float JumpAdd, MaxPressTime;
    public Vector2 JumpForce;
	// Use this for initialization
	void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            body.AddForce(JumpForce * 10);
            PressedTime = Time.time + MaxPressTime;
        }else if (Input.GetButton("Jump"))
        {
            if (Time.time < PressedTime)
            {
                body.AddForce(Vector2.up * JumpAdd);
            }
        } 
	}
}
