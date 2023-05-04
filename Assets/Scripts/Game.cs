using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    private bool isRunning = false;
    
    public void StartGame()
    {
        isRunning = true;
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
