using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowEffectController : MonoBehaviour
{
    public Color glowColor = Color.blue;
    public float glowSize = 1.5f;
    public GameObject ball2;
    public BallMovement ballMovement;
    public GameObject ballObject;

    void Start()
    {
        // Find the "Ball" GameObject using its tag
        ballObject = GameObject.FindGameObjectWithTag("Player");
        ball2 = Instantiate(ballObject, transform.position, transform.rotation);
        Destroy(ball2.GetComponent<BallMovement>());
        Destroy(ball2.GetComponent<CircleCollider2D>());

        // Check if the "Ball" GameObject is found
        if (ballObject != null)
        {
            // Attach the GlowEffect script to the "Ball" GameObject
            GlowEffect glowEffectScript = ballObject.AddComponent<GlowEffect>();

            // Set the properties for the glow effect
            glowEffectScript.glowColor = glowColor;
            glowEffectScript.glowSize = glowSize;
        }
        else
        {
            Debug.LogWarning("Ball GameObject not found.");
        }
    }

    private void Update()
    {
        ball2.transform.position = ballObject.transform.position;
    }
}
