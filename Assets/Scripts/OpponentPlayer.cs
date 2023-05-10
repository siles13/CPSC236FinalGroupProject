using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// need to add impossible mode (Messi mode)
public class OpponentPlayer : MonoBehaviour
{
    public SpriteRenderer OpponentPlayerSpriteRenderer;
    public Ball Ball;
    
    private bool isTouchingBall;
    private bool isPlaying = false;

    void Start()
    {
    }
    
    public void StartGame()
    {
        isPlaying = true;
    }

    public void MoveManually(Vector2 direction)
    {
        Move(direction);
    }
    
    public void Move(Vector2 direction)
    {

        FaceCorrectDirection(direction);

        float xAmount = direction.x * GameParameters.OpponentPlayerMoveAmount;
        float yAmount = direction.y * GameParameters.OpponentPlayerMoveAmount;

        Vector3 moveAmount = new Vector3(xAmount, yAmount, 0f);
        // sprites will be added later
        OpponentPlayerSpriteRenderer.transform.Translate(moveAmount);

        KeepOnScreen();
    }
    
    public void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        {
            // face right
            OpponentPlayerSpriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            // face left
            OpponentPlayerSpriteRenderer.flipX = true;
        }
    }
    
    private void KeepOnScreen()
    {
        // UserPlayerSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(UserPlayerSpriteRenderer);
    }
    
    public void KickBall()
    {
        if (isTouchingBall)
        {
            Ball.GetKicked(transform.position);
        }
    }
    
    public void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ball")
        {
            isTouchingBall = true;
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            isTouchingBall = false;
        }
    }
    
    
    
    
    
        // void Update()
    // {
    //     switch(difficulty)
    //     {
    //         case 1: // easy
    //             Easy();
    //             break;
    //         case 2: // medium
    //             Medium();
    //             break;
    //         case 3: // hard
    //             Hard();
    //             break;
    //         default:
    //             Easy();
    //             break;
    //     }
    // }
    //
    // void FixedUpdate()
    // {
    //     rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    // }
    
    // void Easy()
    // {
    //     Vector2 direction = ball.position - transform.position;
    //     float angle = Vector2.Angle(direction, Vector2.right);
    //     float distance = direction.magnitude;
    //     
    //     if(distance < 5f)
    //     {
    //         if(ball.position.y > transform.position.y)
    //             movement = new Vector2(0, 1);
    //         else
    //             movement = new Vector2(0, -1);
    //     }
    //     else
    //         movement = new Vector2(0, 0);
    // }
    //
    // void Medium()
    // {
    //     Vector2 direction = ball.position - transform.position;
    //     float angle = Vector2.Angle(direction, Vector2.right);
    //     float distance = direction.magnitude;
    //     
    //     if(distance < 5f)
    //     {
    //         if(ball.position.y > transform.position.y + 1f)
    //             movement = new Vector2(0, 1);
    //         else if(ball.position.y < transform.position.y - 1f)
    //             movement = new Vector2(0, -1);
    //         else
    //             movement = new Vector2(0, 0);
    //     }
    //     else
    //         movement = new Vector2(0, 0);
    // }
    //
    // void Hard()
    // {
    //     Vector2 direction = ball.position - transform.position;
    //     float angle = Vector2.Angle(direction, Vector2.right);
    //     float distance = direction.magnitude;
    //     
    //     if(distance < 5f)
    //     {
    //         if(ball.position.y > transform.position.y + 1f)
    //             movement = new Vector2(0, 1);
    //         else if(ball.position.y < transform.position.y - 1f)
    //             movement = new Vector2(0, -1);
    //         else if(distance < 2f)
    //             movement = direction.normalized;
    //         else
    //             movement = new Vector2(0, 0);
    //     }
    //     else
    //         movement = new Vector2(0, 0);
    // }
}
