using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float STEP = 4.0f;
    Rigidbody2D rigid2D;
    float jumpForce = 360.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.velocity = Vector3.zero;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<AudioSource>().Play();
            this.rigid2D.AddForce(transform.up * jumpForce);           
        }

        {
            this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
        }
    }
}
