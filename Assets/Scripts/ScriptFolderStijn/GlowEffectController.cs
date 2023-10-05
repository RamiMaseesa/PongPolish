using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowEffectController : MonoBehaviour
{
    public Color glowColor = Color.green;
    public float glowSize = 1.5f;

    void Start()
    {
        // Find the "Ball" GameObject using its tag
        GameObject ballObject = GameObject.FindGameObjectWithTag("Player");

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
}
