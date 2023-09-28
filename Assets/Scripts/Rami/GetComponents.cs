using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{
    protected BallMovement ball;
    protected virtual void Start()
    {
        ball = FindObjectOfType<BallMovement>();
    }
}
