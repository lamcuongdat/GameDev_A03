using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Cat cat;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        cat = FindObjectOfType<Cat>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="" + cat.score*100;
    }
}
