using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Camera cam;
    public PerlinWorm worm;
    public void TimeSet(float time)
    {
        Time.timeScale = time;
    }
    public void CameraSize(float size)
    {
        cam.orthographicSize = size;
    }

    public void setWormSpeed(float speed)
    {
        worm.speed = speed;
    }
}
