using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    GameObject empty;
    Camera camera = null;
    // Start is called before the first frame update
    void Start()
    {
        empty = new GameObject()
        {
            name = "cameraHolder"
        };
        camera = FindObjectOfType<Camera>();
        camera.transform.parent = empty.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
