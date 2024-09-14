using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : PoolObject
{
    [SerializeField] float speed = 10f;

    [SerializeField] float deSpawnTime = 1f;
    [SerializeField] bool isEnemy;

    private void OnEnable()
    {
        StartCoroutine(TimeOut());
    }

    public IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(deSpawnTime);
        ReturnObject();
        //ObjectPooling.instance.SetPool(PoolObjIndex.Bullet, this.gameObject);
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isEnemy)
        {
            if (collision.CompareTag("Enemy"))
            {
                ReturnObject();
            }
        }
    }
}
