using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectGameobject : MonoBehaviour
{
    void Start()
    {
        // Find the "Ball" GameObject in the scene
        //BallMovement ballObject = FindObjectOfType<BallMovement>();

        GameObject ballObject = GameObject.Find("Ball");

        // Check if the "Ball" GameObject is found
        if (ballObject != null)
        {
            // Attach the GlowEffect script to the "Ball" GameObject
            ChangeShader glowEffectScript = ballObject.AddComponent<ChangeShader>();

            // Set the properties for the glow effect
            glowEffectScript.glowColor = Color.green;
            glowEffectScript.glowSize = 1.5f;
        }
        else
        {
            Debug.LogWarning("Ball GameObject not found.");
        }
    }
}
