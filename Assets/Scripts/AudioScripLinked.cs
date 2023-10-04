using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class AudioScripLinked : MonoBehaviour
{
   
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {

        //hit = GetComponent<AudioClip>();
       // hit = Resources.Load<AudioClip>("Audio/vine-boom (1)");
        //audiosource = GetComponent<AudioSource>();
        
      
       // audiosource.Play();
        //ballMovement = GetComponent<BallMovement>(); 
        // ball = GameObject.Find("Ball");
        //  ball.AddComponent<Rigidbody2D>();
        // rb = ball.GetComponent<Rigidbody2D>();
        // gameObject.AddComponent<BallMovement>();


        //  FindObjectOfType<BallMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("PlayerLeft"))
        {
           
            //Resources.Load("Audio/vine-boom (1)");
            //Resources.Load<AudioClip>("Audio/vine-boom (1)");
            print("sexy");
        }
    }

    // Update is called once per frame

}
