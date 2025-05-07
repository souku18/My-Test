using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject kipfel;
    GameObject house;
    GameObject distance;
    void Start()
    {
        this.kipfel = GameObject.Find("kipfel");
        this.house = GameObject.Find("house");
        this.distance = GameObject.Find("distance");
    }

    
    void Update()
    {
        float length = this.house.transform.position.x -
            this.kipfel.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text =
            "until:" + length.ToString("F2") + "m";
    }
}
