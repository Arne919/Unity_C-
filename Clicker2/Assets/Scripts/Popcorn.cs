using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popcorn : MonoBehaviour
{

    [SerializeField] float speed;

    RectTransform rt;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    void Update()
    {
        rt.anchoredPosition += Vector3.right * Time.deltaTime * speed;
        //transform.position += Vector3.right * Time.deltaTime * speed;
        
    }

}
