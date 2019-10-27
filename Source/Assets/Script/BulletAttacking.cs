using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttacking : MonoBehaviour
{
    public float dmg = 20;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(gameObject);
        }
    }

}
