using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip hit, touch, apply, shoot;
    public AudioSource audioSource;
    public float volume=1;
    // Start is called before the first frame update
    void Start()
    {
        hit = Resources.Load<AudioClip>("Hit");
        apply = Resources.Load<AudioClip>("ApplySound");
        shoot = Resources.Load<AudioClip>("Shoot");
        touch = Resources.Load<AudioClip>("Touch");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play (string s)
    {
        switch (s)
        {
            case "Apply":
                audioSource.clip = apply;
                audioSource.PlayOneShot(apply, volume);
                break;
            case "Hit":
                audioSource.clip = hit;
                audioSource.PlayOneShot(hit, volume);
                break;
            case "Touch":
                audioSource.clip = touch;
                audioSource.PlayOneShot(touch, volume);
                break;
            case "Shoot":
                audioSource.clip = shoot;
                audioSource.PlayOneShot(shoot, volume);
                break;
        }
    }
}
