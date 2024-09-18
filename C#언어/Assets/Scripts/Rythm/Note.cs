using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Note : MonoBehaviour
{
    public float speed = 3;
    public TextMeshPro scoreText;


    // Update is called once per frame
    void Update()
    {
        //나 자신의 현재 위치    누적    방향            보정          속력
        this.transform.position += Vector3.down * Time.deltaTime * speed;

    
        //if (this.transform.position.y < -6f)
        //{
        //    Destroy(this.gameObject);
        //}

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "deadline")
    //        Destroy(gameObject);
    //}


    private void OnCollisionEnter2D(Collision2D collision) //
    {
        if (collision.gameObject.tag == "deadline")
        {
            GamemanagerRythm.instance.SetScore(-5);
            Destroy(gameObject);
        }

    }
}
