using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : PoolObject
{
    [SerializeField] float speed = 5f;
    [SerializeField] float shootSpeed = 0.5f;
    [SerializeField] float deSpawnTime = 1f;
    [SerializeField] GameObject bullet;

    private void OnEnable()
    {
        StartCoroutine(Shoot());
        StartCoroutine(TimeOut());
    }

    public IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(deSpawnTime);
        ReturnObject();
        //ObjectPooling.instance.SetPool(PoolObjIndex.Enemy, this.gameObject);
    }


    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootSpeed);
            GameObject tempBullet = ObjectPooling.instance.GetPool(PoolObjIndex.EnemyBullet);
            tempBullet.transform.position = this.transform.position;
            tempBullet.transform.rotation = this.transform.rotation;
            //tempBullet.transform.up = Player.instance.transform.position - transform.position;
        }
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBullet"))
        {
            ReturnObject();
        }
    }
}
