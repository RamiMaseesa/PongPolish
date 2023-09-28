using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BallParticleEffect : GetComponents
{
    private TrailRenderer trail;

    protected override void Start()
    {
        base.Start();

        trail = ball.gameObject.AddComponent<TrailRenderer>();

        TrailOneSettings();

    }

    private void TrailOneSettings()
    {
        trail.startColor = new Color(0.0f, 0.0f, 1.0f, 1.0f);
        trail.endColor = new Color(1.0f, 0.0f, 1.0f, 0.0f);

        trail.startWidth = 0.3f;
        trail.endWidth = 0.01f;

        trail.material = new Material(Shader.Find("Sprites/Default"));
        trail.material.renderQueue = 1;

        trail.time = .5f;
    }

}
