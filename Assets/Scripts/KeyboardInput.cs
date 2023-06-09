using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public UserPlayer UserPlayer;
    public OpponentPlayer OpponentPlayer;
    public Sounds Sounds;
    void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                UserPlayer.MoveManually(new Vector2(0, 1));
            }
            if (Input.GetKey(KeyCode.A))
            {
                UserPlayer.MoveManually(new Vector2(-1, 0));
            }
            if (Input.GetKey(KeyCode.D))
            {
                UserPlayer.MoveManually(new Vector2(1, 0));
            }
            if (Input.GetKey(KeyCode.S))
            {
                UserPlayer.MoveManually(new Vector2(0, -1));
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                OpponentPlayer.MoveManually(new Vector2(0, 1));
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                OpponentPlayer.MoveManually(new Vector2(-1, 0));
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                OpponentPlayer.MoveManually(new Vector2(1, 0));
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                OpponentPlayer.MoveManually(new Vector2(0, -1));
            }
    
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UserPlayer.KickBall();
                Sounds.PlayKickBallSound();
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                OpponentPlayer.KickBall();
                Sounds.PlayKickBallSound();
            }
        }
}
