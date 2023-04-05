using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Obstecle //Inheritance
{
    private float speedMultiplayer = 2f;
    private void Start()
    {
        Speed += speedMultiplayer;
        Debug.Log($"{Speed}");
        Speed -= speedMultiplayer;
        Speed -= speedMultiplayer;
        Debug.Log($"{Speed}");
    }
    public override void Move()
    {
        //Polymorphism - choose your behaviors
        transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
    void Update()
    {
        Move(); //Abstraction - choose your functions
    }
}
