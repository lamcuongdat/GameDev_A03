using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTrigger : MonoBehaviour
{
    public Cat cat;
    public Sound sound;
    // Start is called before the first frame update
    void Start()
    {
        cat = FindObjectOfType<Cat>();
        sound = FindObjectOfType<Sound>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger == false && collision.CompareTag("Enemy"))
        {
            collision.SendMessageUpwards("Damg");
            cat.health--;
            sound.Play("Touch");
        }
    }
}
