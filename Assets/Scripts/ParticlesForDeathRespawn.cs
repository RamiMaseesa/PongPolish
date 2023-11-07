using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

public class ParticlesForDeathRespawn : MonoBehaviour
{
    public List<GameObject> ballparticles = new List<GameObject> { };

    GameObject ballParticleClone;
    SpriteRenderer ballParticleSprite;
    GameObject ball;
    GameObject ballParticle;
    Transform ballEndLocation;

    UnityEngine.Quaternion randomRotation;

    #region lerp
    public float speed;

    public float startTime;

    private float journeyLength;

    public float timer;
    #endregion

    void Start()
    {

        //nieuwe gameobject wordt aangemaakt
        ballParticle = new GameObject("particle");
        ballParticle.SetActive(false);

        //Gameobject wordt een spriterenderer aan gelinkt
        ballParticleSprite = ballParticle.AddComponent<SpriteRenderer>();

        //pakt de gameobject ball 
        ball = FindObjectOfType<BallMovement>().gameObject;

        //pakt de spriterenderer van de ball en daarvan de sprite
        ballParticleSprite.sprite = ball.GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {
        MoveBall();
    }

    //Instatiates particles for use of the explosion
    private void instantiateParticles(string direction)
    {
        for (int amount = 0; amount < 8; amount++)
        {
            float randomZRotation = Random.Range(0f, 360f);
            randomRotation = UnityEngine.Quaternion.Euler(0f, 0f, randomZRotation);
            ballParticleClone = Instantiate(ballParticle, ballEndLocation.transform.position, randomRotation);
            
            ballParticleClone.transform.position = ballEndLocation.transform.position;
            ballparticles.Add(ballParticleClone);
        }
        foreach (GameObject ballparticle in ballparticles)
        {
            ballparticle.SetActive(true);
            Destroy(ballParticleClone, 3);
        }
        //ballparticles.Clear();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BoundLeft")
        {
            print("Left " + gameObject.transform.position);
            ballEndLocation = gameObject.transform;
            instantiateParticles("Left");
        }

        if (other.gameObject.tag == "BoundRight")
        {
            print("Right " + gameObject.transform.position);
            ballEndLocation = gameObject.transform;
            instantiateParticles("Right");
        }
    }

    private void MoveBall()
    {
        if (ballparticles !=  null)
        {
            foreach (GameObject ballparticle in ballparticles)
            {
                ballparticle.transform.position += ballparticle.transform.right * Time.deltaTime;
            }
        }

    }
}
