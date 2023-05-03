using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SpriteRenderer BallSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SwitchSides(Vector2 direction)
    {
        if (direction.x > 0)
        {
            // make ball face right side of userplayer
            //BallSpriteRenderer.transform.position = new Vector3(UserPlayerPosition.x, UserPlayerPosition.y, UserPlayerPosition.z);
        }
        else if (direction.x < 0)
        {
            // make ball face last side of userplayer, currently not working
            BallSpriteRenderer.transform.position = new Vector3(-BallSpriteRenderer.transform.position.x, BallSpriteRenderer.transform.position.y, BallSpriteRenderer.transform.position.z);
        }
    }
}
