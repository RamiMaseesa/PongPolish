using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowEffect : MonoBehaviour
{
    public Color glowColor = Color.green;
    public float glowSize = 1.5f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Optional: Set the material to enable emission
        spriteRenderer.material.EnableKeyword("_EMISSION");
    }

    void Update()
    {
        // Set the color to the desired glow color
        spriteRenderer.color = glowColor;

        // Scale the sprite to create a glow-like effect
        transform.localScale = new Vector3(glowSize, glowSize, 1f);
    }
}
