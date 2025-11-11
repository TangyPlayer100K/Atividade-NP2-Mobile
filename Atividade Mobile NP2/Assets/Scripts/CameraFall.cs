using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraFall : MonoBehaviour
{
    public GameObject ball;
    public float ballHeightStart;
    public float ballHeightUPDT;
    public int level = 0;

    Vector3 camPos = new Vector3(0f, 14f, 0);

    void Start()
    {
        ballHeightStart = ball.transform.position.y;
    }

    void Update()
    {
        ballHeightUPDT = ball.transform.position.y; //questionar o "gameObject."

        if (ballHeightUPDT <  ballHeightStart - 10 && level == 0)
        {
            camPos = new Vector3(0f, 4f, 0f);
            level = 1;
            SetCameraHeight();
            Debug.Log("level 2");
        }
        if (ballHeightUPDT < ballHeightStart - 20 && level == 1)
        {
            camPos = new Vector3(0f, -4f, 0f);
            level = 2;
            SetCameraHeight();
            Debug.Log("level 3");
        }
        if (ballHeightUPDT < ballHeightStart - 30 && level == 2)
        {
            camPos = new Vector3(0f, -14f, 0f);
            level = 3;
            SetCameraHeight();
            Debug.Log("level 4");
        }
    }

    public void SetCameraHeight()
    {
        transform.position = camPos;
    }
}
