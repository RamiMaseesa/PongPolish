using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GetComponents : MonoBehaviour
{
    protected BallMovement ball;
    protected PlayerMovement[] players;
    protected virtual void Start()
    {
        ball = FindObjectOfType<BallMovement>();

        players = FindObjectsOfType<PlayerMovement>();
    }
}
