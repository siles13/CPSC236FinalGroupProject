using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameTimer GameTimer;
    public Text TimeText;

    public void ShowTime(string time)
    {
        TimeText.text = time;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowTime(GameTimer.GetTimeAsString());
    }
}
