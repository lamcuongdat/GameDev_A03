using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    public float minY = -3.5f, maxY = 4f, speed = 0.1f;
    public bool isUp = true;
    public GameObject test;
    public Vector2 newPos;
    void Start()
    {
        newPos = GetComponent<Transform>().position;
        newPos.y = Random.Range(minY, maxY);
        GetComponent<Transform>().position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        newPos = GetComponent<Transform>().position;
        if(newPos.y>=maxY)
        {
            isUp = false;
        }
        if (newPos.y <= minY)
        {
            isUp = true;
        }
        if(isUp==true)
        {
            newPos.y += speed;
        }
        else
        {
            newPos.y -= speed;
        }
        GetComponent<Transform>().position = newPos;
    }
}
