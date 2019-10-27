using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartUI : MonoBehaviour
{
    public Sprite[] HeartSprites;
    Cat cat;
    public Image Heart;
    // Start is called before the first frame update
    void Start()
    {
        cat = FindObjectOfType<Cat>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cat.health >= 0)
        Heart.sprite = HeartSprites[cat.health];
    }
}
