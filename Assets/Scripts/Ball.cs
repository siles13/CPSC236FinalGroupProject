using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D physics;
    private float startSpeed = 300;

    public SpriteRenderer BallSpriteRenderer;
    
    void Awake()
    {
        physics = gameObject.GetComponent<Rigidbody2D>();
    }

    public void GetKicked(Vector3 playerPosition)
    {
        float yDifference = (playerPosition.y - transform.position.y) * -1;
        float xDifference = (playerPosition.x - transform.position.x);
        float xMultiplier = 1f;

        if (xDifference > 0)
            xMultiplier = -1f;

        physics.isKinematic = false;
        physics.AddForce(new Vector3(startSpeed * xMultiplier, startSpeed * yDifference, 0f));
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftGoal")
        {
            print("score");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "LeftGoal")
        {
            print("score");
        }
    }

    void Update()
    {
    }
}
