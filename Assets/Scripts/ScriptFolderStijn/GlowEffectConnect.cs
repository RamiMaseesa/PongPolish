using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowEffectConnect : MonoBehaviour
{
    void Start()
    {
        // Find the GameObject named "GameController"
        GameObject gameController = GameObject.Find("GameController");

        // Check if the GameObject was found
        if (gameController != null)
        {
            // Attach the GlowEffectController script to the "GameController" GameObject
            GlowEffectController glowController = gameController.AddComponent<GlowEffectController>();

            // Configure properties (optional)
            glowController.glowColor = Color.blue;
            glowController.glowSize = 2.0f;
        }
        else
        {
            Debug.LogWarning("GameObject named 'GameController' not found.");
        }
    }
}
