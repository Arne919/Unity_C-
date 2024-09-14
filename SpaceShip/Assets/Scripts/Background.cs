using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    float speed = 3f;
    Vector3 targetPos = Vector3.up * 10.8f * 2;

    void Update()
    {
        this.transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (this.transform.position.y < -10.8)
        {
            this.transform.position += targetPos;
        }

    }
}
