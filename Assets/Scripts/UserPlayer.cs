using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserPlayer : MonoBehaviour
{
    public SpriteRenderer UserPlayerSpriteRenderer;
    public Ball Ball;
    public Game Game;

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

        float xAmount = direction.x * GameParameters.UserPlayerMoveAmount;
        float yAmount = direction.y * GameParameters.UserPlayerMoveAmount;

        Vector3 moveAmount = new Vector3(xAmount, yAmount, 0f);
        // sprites will be added later
        UserPlayerSpriteRenderer.transform.Translate(moveAmount);

        KeepOnScreen();
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

    public void KickBall()
    {
        if (isTouchingBall)
        {
            Ball.GetKicked(transform.position);
        }
    }
    
    private void KeepOnScreen()
    {
        // UserPlayerSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(UserPlayerSpriteRenderer);
    }
    
    public void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        {
            // face right
            UserPlayerSpriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            // face left
            UserPlayerSpriteRenderer.flipX = true;
        }
    }
}
