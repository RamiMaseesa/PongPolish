using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class AudioScripLinked : MonoBehaviour
{
    public AudioClip hit;
    public AudioClip goal;
    public AudioSource audioSource;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        
        hit = Resources.Load<AudioClip>("Audio/vine-boom (1)");
        goal = Resources.Load<AudioClip>("Audio/rocket-league-save");
        audioSource = gameObject.AddComponent<AudioSource>();
       
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("PlayerLeft") || collision.gameObject.tag == ("PlayerRight"))
        {
            audioSource.PlayOneShot(hit);
            //Resources.Load("Audio/vine-boom (1)");
            //Resources.Load<AudioClip>("Audio/vine-boom (1)");
            print("sexy");
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("BoundLeft") || collision.gameObject.tag == ("BoundRight"))
        {
            print("hallo");
            audioSource.PlayOneShot(goal);
        }
    }

    // Update is called once per frame

}
