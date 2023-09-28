using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{
    public Color glowColor = Color.green;
    public float glowSize = 1.5f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        spriteRenderer.color = glowColor;

        transform.localScale = new Vector3(glowSize, glowSize, 1f);
    }
}
