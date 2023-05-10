using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public UI UI;
    public GameTimer GameTimer;
    private bool isRunning = false;
    public Sounds Sounds;
    public UserPlayer UserPlayer;
    public OpponentPlayer OpponentPlayer;

    public void StartGame()
    {
        isRunning = true;
        
        GameTimer.StartTimer(120);
        
        UserPlayer.StartGame();
        
        OpponentPlayer.StartGame();
        
        Sounds.PlayCrowdNoise();
    }
    
    public bool HasGameJustEnded()
    {
        if (isRunning && !GameTimer.IsRunning())
            return true;
        return false;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void EndGame()
    {

    }

    public bool IsRunning()
    {
        return isRunning;
    }
}
