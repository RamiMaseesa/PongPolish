using UnityEngine;

public class StartGameText : MonoBehaviour
{
    BallMovement ballMovement;
    GameObject playText;
    GameObject empty;
    Camera camera;
    
    private void Awake()
    {
        Camera.main.gameObject.AddComponent<Screenshake>();
    }
    void Start()
    {
        ballMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMovement>();
        ballMovement.gameObject.AddComponent<BallBounceCheck>();
        playText = GameObject.FindGameObjectWithTag("PlayText");
        empty = new GameObject()
        {
            name = "cameraHolder"
        };
        camera = FindObjectOfType<Camera>();
        camera.transform.parent = empty.transform;
    }

    void Update()
    {
        if (ballMovement.isPlay) playText.SetActive(false);
        else playText.SetActive(true);
    }
}
