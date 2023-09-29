using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BallParticleEffect : GetComponents
{
    private TrailRenderer trail;
    private TrailRenderer playerTrail;
    protected override void Start()
    {
        base.Start();

        TrailOneSettings();
        GivePlanesTrail();
    }
    private void TrailOneSettings()
    {
        //add a TrailRenderer component to the ball
        trail = ball.gameObject.AddComponent<TrailRenderer>();

        // change the settings
        trail.startColor = new Color(0.0f, 0.0f, 1.0f, 1.0f);
        trail.endColor = new Color(1.0f, 0.0f, 1.0f, 0.0f);

        trail.startWidth = 0.3f;
        trail.endWidth = 0.01f;

        trail.material = new Material(Shader.Find("Sprites/Default"));
        trail.material.renderQueue = 1;

        trail.time = .5f;
    }

    private void GivePlanesTrail()
    {
        // for each object in players add trailrenderer componenet
        foreach(PlayerMovement player in players)
        {
            playerTrail = player.gameObject.AddComponent<TrailRenderer>();

            playerTrail.startColor = new Color(0.0f, 0.0f, 1.0f, 1.0f);
            playerTrail.endColor = new Color(1.0f, 0.0f, 1.0f, 0.0f);

            playerTrail.startWidth = 1f;
            playerTrail.endWidth = 0.1f;

            playerTrail.material = new Material(Shader.Find("Sprites/Default"));
            playerTrail.material.renderQueue = 0;

            playerTrail.time = 1f;
        }
    }

}
