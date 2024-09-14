
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;


    [SerializeField] GameObject bullet;
    [SerializeField] float speed = 3f;
    [SerializeField] float shootSpeed = 0.5f;
    Vector3 mov = Vector3.zero;

    private void Awake()
    {
        instance = this;
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject temp = ObjectPooling.instance.GetPool(PoolObjIndex.Bullet);
                temp.transform.position = transform.position;
                temp.transform.rotation = transform.rotation;
                yield return new WaitForSeconds(shootSpeed);
            }
            else
            {
                yield return null;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        mov.x = Input.GetAxis("Horizontal");
        mov.y = Input.GetAxis("Vertical");

        this.transform.position += mov * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") || collision.CompareTag("EnemyBullet"))
        {
            GameManager.instance.GameOver();
            Time.timeScale = 0;
        }
    }
}
