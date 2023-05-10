using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// need to add impossible mode (Messi mode)
public class OpponentPlayerController : MonoBehaviour
{ 
    public float speed = 5f;
    public float difficulty = 1f; // 1 = easy, 2 = medium, 3 = hard
    public Transform ball;
    private Rigidbody2D rb;
    private Vector2 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        switch(difficulty)
        {
            case 1: // easy
                Easy();
                break;
            case 2: // medium
                Medium();
                break;
            case 3: // hard
                Hard();
                break;
            default:
                Easy();
                break;
        }
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    
    void Easy()
    {
        Vector2 direction = ball.position - transform.position;
        float angle = Vector2.Angle(direction, Vector2.right);
        float distance = direction.magnitude;
        
        if(distance < 5f)
        {
            if(ball.position.y > transform.position.y)
                movement = new Vector2(0, 1);
            else
                movement = new Vector2(0, -1);
        }
        else
            movement = new Vector2(0, 0);
    }
    
    void Medium()
    {
        Vector2 direction = ball.position - transform.position;
        float angle = Vector2.Angle(direction, Vector2.right);
        float distance = direction.magnitude;
        
        if(distance < 5f)
        {
            if(ball.position.y > transform.position.y + 1f)
                movement = new Vector2(0, 1);
            else if(ball.position.y < transform.position.y - 1f)
                movement = new Vector2(0, -1);
            else
                movement = new Vector2(0, 0);
        }
        else
            movement = new Vector2(0, 0);
    }
    
    void Hard()
    {
        Vector2 direction = ball.position - transform.position;
        float angle = Vector2.Angle(direction, Vector2.right);
        float distance = direction.magnitude;
        
        if(distance < 5f)
        {
            if(ball.position.y > transform.position.y + 1f)
                movement = new Vector2(0, 1);
            else if(ball.position.y < transform.position.y - 1f)
                movement = new Vector2(0, -1);
            else if(distance < 2f)
                movement = direction.normalized;
            else
                movement = new Vector2(0, 0);
        }
        else
            movement = new Vector2(0, 0);
    }
}
