using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Enemy : MonoBehaviour, IOnHit
{
    [SerializeField] float speed = 2;
    [SerializeField] float shootSpeed;
    [SerializeField] Transform bullet;
    

    Transform player;

    IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }

    IEnumerator Shoot()
    {

        while (true)
        {
            yield return new WaitForSeconds(shootSpeed); //0.5초

            //Transform temp = Transform.Instantiate(bullet);
            Transform temp = ObjectPooling.instance.GetPool(PoolFlag.ebullet).transform;
            temp.position = this.transform.position;

            //총알로부터의 플레이어 까지의 크기와 방향
            temp.up = player.position - temp.position;
        }
    }

    private void Start()
    {
        player = Gamemanager.instance.player.transform;
    }

    private void OnEnable()
    {
        StartCoroutine(Shoot());
        StartCoroutine(TimeOut());
    }

    void Update()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    public void OnHit(int damage)
    {
        ObjectPooling.instance.SetPool(this.gameObject, PoolFlag.enemy);
    }
}

//공격자 -> ebullet pbullet
//피격자 -> plaer enemy