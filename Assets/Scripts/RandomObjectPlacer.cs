using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomObjectPlacer : MonoBehaviour
{
    // Start is called before the first frame update
    public Game Game;
    public GameObject ObjectPrefab;
    protected bool isWaitingToCreate = false;

    protected float minimumTimeUntilCreate = 1f;
    protected float maximumTimeUntilCreate = 3f;

    private float secondsUntilCreation;
    private Coroutine TimerCoroutine;
    private bool hasReset = false;
    
    public void Update()
    {
        // if the game has started
        if (Game.IsRunning())
        {
            hasReset = false;
            if (isWaitingToCreate == false)
            {
                secondsUntilCreation = Random.Range(minimumTimeUntilCreate, maximumTimeUntilCreate);
                TimerCoroutine = StartCoroutine(CountDownUntilCreation());
            }

        }
        else if (!hasReset)
        {
            ResetPlacer();
        }
    }

    IEnumerator CountDownUntilCreation()
    {
        isWaitingToCreate = true;
        yield return new WaitForSeconds(secondsUntilCreation);
        Place();
    }

    protected virtual void Place()
    {
        Vector3 position = SpriteTools.RandomLocationWorldSpace();
        Instantiate(ObjectPrefab, position, Quaternion.identity);
        isWaitingToCreate = false;
    }

    private void ResetPlacer()
    {
        isWaitingToCreate = false;
        if (TimerCoroutine != null)
            StopCoroutine(TimerCoroutine);
        DeleteAllPlacedObjects();
        hasReset = true;
    }

    private void DeleteAllPlacedObjects()
    {
        foreach (GameObject placedObject in GameObject.FindGameObjectsWithTag(ObjectPrefab.tag))
        {
            Destroy(placedObject);
        }
    }
}
