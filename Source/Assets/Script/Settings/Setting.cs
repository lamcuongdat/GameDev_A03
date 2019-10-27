using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public GameObject  SettingUI;
    public GameObject scoreUI, heartUI, volumeUI, volumeSlideBar;
    public bool isDisplay = true;
    public Sound audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        SettingUI = gameObject;
        scoreUI.SetActive(false);
        heartUI.SetActive(false);
        volumeUI.SetActive(false);
        Time.timeScale = 0;
        audioSrc = GameObject.FindObjectOfType<Sound>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        scoreUI.SetActive(true);
        heartUI.SetActive(true);
        Time.timeScale = 1;
        SettingUI.SetActive(false);
    }
    public void Volume()
    {
        volumeUI.SetActive(true);
        SettingUI.SetActive(false);
    }
    public void Back()
    {
        SettingUI.SetActive(true);
        scoreUI.SetActive(false);
        heartUI.SetActive(false);
        volumeUI.SetActive(false);
    }
    public void Volume(float value)
    {
        audioSrc.volume = value*1f/100;
    }
    public void Apply()
    {
        audioSrc.Play("Apply");
    }
}
