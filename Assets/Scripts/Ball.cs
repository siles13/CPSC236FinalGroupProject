using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody physics;
    private float startSpeed = 300;
    private bool canLaunch = false;

    public SpriteRenderer BallSpriteRenderer;
    
    void Awake()
    {
        physics = gameObject.GetComponent<Rigidbody>();
    }

    public void GetKicked()
    {
        print("kicked");
    }
    
    
    private void Launch()
    {
        physics.isKinematic = false;
        physics.AddForce(new Vector3(startSpeed, startSpeed, 0f));
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canLaunch = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canLaunch = false;
        }
    }

    void Update()
    {
        if (canLaunch && Input.GetButtonDown("Jump"))
        {
            Launch();
            canLaunch = false;
        }
    }
}
