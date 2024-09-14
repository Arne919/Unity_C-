using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] int damage = 1;
    public PoolFlag flag;

    IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(5f);
        ReturnBullet();
    }

    public void ReturnBullet()
    {
        ObjectPooling.instance.SetPool(this.gameObject, flag);     
    }

    private void Awake()
    {
        StartCoroutine(TimeOut());
    }

    void Update()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        IOnHit hit = collision.GetComponent<IOnHit>();
        if (hit == null)
            return;

        hit.OnHit(damage);
        ReturnBullet();


        //if (collision.CompareTag("OutLine"))
        //{
        //    ReturnBullet();
        //}
    }
}
