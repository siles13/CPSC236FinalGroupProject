using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoccerCleats : TimedLifespan
{
    public override void Start()
    {
        secondsOnScreen = GameParameters.SoccerCleatsSecondsOnScreen;
        base.Start();
    } 
}
