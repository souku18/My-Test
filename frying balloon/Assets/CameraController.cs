using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float px;

    void Update()
    {
        px = GameObject.Find("kipfel").transform.position.x;
        this.transform.position = new Vector3(px+4, 0, -20.0f);
    }
}
