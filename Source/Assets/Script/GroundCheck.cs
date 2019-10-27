using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Cat cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = gameObject.GetComponentInParent<Cat>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cat.grounded = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        cat.grounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        cat.grounded = false;   
    }
}
