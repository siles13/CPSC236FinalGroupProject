using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource KickBall;
    public AudioSource CrowdNoise;
    public AudioClip KickBallClip;
    public AudioClip CrowdNoiseClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayKickBallSound()
    {
        KickBall.clip = KickBallClip;
        KickBall.Play();
    }

    public void PlayCrowdNoise()
    {
        CrowdNoise.clip = CrowdNoiseClip;
        CrowdNoise.Play();
    }
}
