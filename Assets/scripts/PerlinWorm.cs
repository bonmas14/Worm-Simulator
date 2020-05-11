using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinWorm : MonoBehaviour
{
    // Start is called before the first frame update
    public float step = 0.01f;
    public float XLimit = 50f;

    public Rigidbody2D main;

    public float speed = 2;
    public Camera cam;
    float Xcoord = 0.00f;
    float Ycoord = 0.00f;
    float YspeedStep = 0.00f;


    private void Start()
    {
        newYCoord();
    }

    void newYCoord()
    {
        Ycoord = Random.Range(0.00f, 10000.00f);
    }

    void FixedUpdate()
    {
        WormLook();
        WormWalk();
        FixCam();
    }

    void FixCam()
    {
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
    }

    void WormLook()
    {
        float rotation = Mathf.PerlinNoise(Xcoord, Ycoord);

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(-360f, 360f, rotation));

        Xcoord += step;

        if (Xcoord > XLimit)
        {
            newYCoord();
            Xcoord = 0.00f;
            YspeedStep = 0f;
        }
    }

    void WormWalk()
    {
        float _speed = Mathf.PerlinNoise(Xcoord, Ycoord + YspeedStep);
               
        main.AddForce(transform.up * Mathf.Lerp(1f, speed, _speed));

        YspeedStep += step;
    }
}
