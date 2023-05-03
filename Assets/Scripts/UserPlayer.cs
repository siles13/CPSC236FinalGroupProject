using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserPlayer : MonoBehaviour
{
    public SpriteRenderer UserPlayerSpriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
    
    private void KeepOnScreen()
    {
        //CorgiSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(CorgiSpriteRenderer);
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
