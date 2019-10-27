using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatShoot : MonoBehaviour
{
    public bool shoot = false;
    public float shootDelay = 0.5f;
    public Animator anim;
    public Object bulletRef;
    public Sound sound;
    // Start is called before the first frame update
    void Start()
    {
       anim= GetComponent<Animator>();
       sound = GameObject.FindObjectOfType<Sound>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isShoot", shoot);
        bulletRef = Resources.Load("Bullet_6");
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shoot == false)
        {
            shoot = true;
            sound.Play("Shoot");
            GameObject bullet = (GameObject)Instantiate(bulletRef);
            bullet.transform.position = new Vector3(transform.position.x + .2f,transform.position.y+.2f,transform.position.z);
            shootDelay = 0.5f;
        }
        if (shoot == true)
        {
            if (shootDelay > 0)
            {
                shootDelay -= Time.deltaTime;
            }
            else
            {
                shoot = false;
            }
        }
    }
}
