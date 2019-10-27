using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rg2d;
    SpriteRenderer rend;
    Cat cat;
    int k;

    float maxX = 20, minX = -26;
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        cat = FindObjectOfType<Cat>();
        rg2d.gravityScale = 0f;
        rend.sortingOrder = 2;
        if (!cat.faceRight)
        {
            k = -1;
        }
        else
        {
            k = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(transform.position.x + 0.2f*k, transform.position.y, transform.position.z);
        transform.position = pos;
        if(transform.position.x > maxX || transform.position.x < minX)
        {
            Destroy(gameObject);
        }
    }
}
