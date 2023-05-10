using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public GameObject BallObject;
    
    // Start is called before the first frame update
    void Start()
    {
        FollowBall();
    }

    // Update is called once per frame
    void Update()
    {
        FollowBall();
    }

    private void FollowBall()
    {
        transform.position = new Vector3(
            BallObject.transform.position.x, BallObject.transform.position.y,
            transform.position.z);
    }
}
