using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float smoothX, smoothY;
    public bool limitCamera;
    public Vector2 maxPos, minPos;
    public Vector2 velocity;

    public GameObject cat;
    void Start()
    {
        cat = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(this.transform.position.x, cat.transform.position.x, ref velocity.x, smoothX);
        float posY = Mathf.SmoothDamp(this.transform.position.y, cat.transform.position.y, ref velocity.y, smoothY);

        if (limitCamera)
        {
            posX = Mathf.Clamp(posX, minPos.x, maxPos.x);
            posY = Mathf.Clamp(posY, minPos.y, maxPos.y);
        }
        this.transform.position = new Vector3(posX, posY, this.transform.position.z);
    }
}
