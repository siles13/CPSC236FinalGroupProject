using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerCleatsPlacer : RandomObjectPlacer
{
    public void Start()
    {
        minimumTimeUntilCreate = GameParameters.SoccerCleatsMinimumTimeToCreate;
        maximumTimeUntilCreate = GameParameters.SoccerCleatsMaximumTimeToCreate;
    }

    protected override void Place()
    {
        Vector3 position = SpriteTools.RandomTopOfScreenLocationWorldSpace();
        Instantiate(ObjectPrefab, position, Quaternion.identity);
        isWaitingToCreate = false;
    }
}
