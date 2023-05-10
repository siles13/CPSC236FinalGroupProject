using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameTimer GameTimer;
    public Text TimeText;
    public Text PlayerScoreText;
    public Text OpponentScoreText;

    public void ShowTime(string time)
    {
        TimeText.text = time;
    }
    
    public void ShowPlayerScore(int score)
    {
        PlayerScoreText.text = "PlayerScore: " + score;
    }

    public void ShowOpponentScore(int score)
    {
        OpponentScoreText.text = "OpponentScore: " + score;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowPlayerScore(ScoreKeeper.GetScore()); 
        ShowOpponentScore(ScoreKeeper.GetScore());
        ShowTime(GameTimer.GetTimeAsString());
    }
}
