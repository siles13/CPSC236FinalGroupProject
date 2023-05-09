using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameTimer GameTimer;
    private bool isRunning = false;
    
    public void StartGame()
    {
        isRunning = true;
        
        GameTimer.StartTimer(120);
        
        //Player.StartGame();
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
