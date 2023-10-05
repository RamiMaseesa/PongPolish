using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource sound;
    AudioClip clip;
    AudioScripLinked audio;
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        sound = Resources.Load<AudioSource>("Audio/vine-boom (1)");
        clip = Resources.Load<AudioClip>("Audio/vine-boom (1)");
        ball = GameObject.Find("Ball");
        ball.AddComponent<AudioScripLinked>();
        ball.AddComponent<AudioSource>();
        
        
        
        


    }

   

    // Update is called once per frame
   
}
