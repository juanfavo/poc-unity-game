using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float flapStrength;
    public bool birdIsAlive = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch phase is began or ended
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Ended)
            {
                rigidBody2D.velocity = Vector2.up * flapStrength;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
    }
}
