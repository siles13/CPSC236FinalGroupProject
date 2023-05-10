using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource AudioSource;
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
        AudioSource.clip = KickBallClip;
        AudioSource.Play();
    }

    public void PlayCrowdNoise()
    {
        AudioSource.clip = CrowdNoiseClip;
        AudioSource.Play();
    }
}
