using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    protected BallMovement script;
    void Awake()
    {
        BallMovement ballMovement = FindObjectOfType<BallMovement>();
        ballMovement.gameObject.AddComponent<ParticlesForDeathRespawn>();
    }
}
