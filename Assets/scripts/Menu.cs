using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Copyright (c) 2020 BonMAS14
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
