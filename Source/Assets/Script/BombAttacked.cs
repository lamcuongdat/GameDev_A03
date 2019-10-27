using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAttacked : MonoBehaviour
{
    Cat cat;
    Sound sound;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        cat = FindObjectOfType<Cat>();
        sound = FindObjectOfType<Sound>();
    }
    void Damg()
    {
        Destroy(gameObject);
        sound.Play("Hit");
        cat.score++;
    }
}
