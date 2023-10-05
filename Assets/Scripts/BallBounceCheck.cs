using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceCheck : MonoBehaviour
{
    Screenshake screenshake;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        screenshake = Camera.main.GetComponent<Screenshake>();
        StartCoroutine(screenshake.Shake(0.15f, 0.4f));
    }
}
