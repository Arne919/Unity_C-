using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    Vector3 distance;
    private void Awake()
    {
        distance = this.transform.position - target.position;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position + distance;
    }
}
