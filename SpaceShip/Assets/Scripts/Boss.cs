using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour, IOnHit
{
    Transform player;
    int hp = 100;

    [SerializeField] int phase = 0;

    public void OnHit(int damage)
    {
        hp -= damage;

        if (phase != 1 && hp < 49)
        {
            //phase = 1;
            StopCoroutine(coru);
            StopCoroutine(cpCoru);

            StartCoroutine(ChoicePhase());
        }
        if (hp < 20 )
        {
            StopCoroutine(coru);
            StopCoroutine(cpCoru);

            StartCoroutine(ChoicePhase());

            Destroy(gameObject);
        }
    }
    /// <summary>
    /// 현재 공격 패턴
    /// </summary>
    Coroutine coru;

    /// <summary>
    /// 페이즈에 따른 공격패턴 관리
    /// </summary>
    Coroutine cpCoru;



    /// <summary>
    /// 등장씬
    /// </summary>
    /// <returns></returns>
    IEnumerator Show()
    {
        while (transform.position.y > 3)
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * 3f);

            yield return null;
        }
        cpCoru = StartCoroutine(ChoicePhase());

        StopCoroutine(coru);
        StopCoroutine(cpCoru);
        cpCoru = StartCoroutine(ChoicePhase());

        yield return new WaitForSeconds(0.25f);

        StopCoroutine(coru);
        StopCoroutine(cpCoru);
        cpCoru = StartCoroutine(ChoicePhase());

        //cpCoru = StartCoroutine(ChoicePhase());

        //StartCoroutine(Circle());
        //coru = StartCoroutine(ShootCircle());
        //yield return new WaitForSeconds(3);
        //StopCoroutine(coru);
        //StartCoroutine(ShootAngle());

    }

    IEnumerator ChoicePhase()
    {
        while (true)
        {
            switch (phase)
            {
                case 0:

                    switch(Random.Range(0,3))
                    {
                        case 0:
                            coru = StartCoroutine(ShootAngle());
                            break;
                        case 1:
                            coru = StartCoroutine(Stay());
                            break;
                        case 2:
                            coru = StartCoroutine(ShootCircle());
                            break;
                    }
                    yield return coru;
                    break;
                case 1:
                    coru = StartCoroutine(Stay2());
                    
                    yield return coru;
                    break;
            }
        }

    }


    [SerializeField] float speed = 3f;
    [SerializeField] float xSize = 1f;
    [SerializeField] float ySize = 1f;


    Vector3 targetPos = Vector3.zero;

    IEnumerator Circle()
    {
        //StartCoroutine(ShootCircle());
        float t = 0;

        Vector3 startpos = this.transform.position;
        startpos.x = 0;
        startpos.z = 0;

        float radius = 0;

        while (true)
        {
            t += Time.deltaTime;
            if (radius < 1)
            {
                radius += Time.deltaTime * 0.2f;
            }

            targetPos.x = Mathf.Sin(t * speed) * xSize;
            targetPos.y = Mathf.Cos(t * speed) * ySize;
            //targetPos.x = 16 * Mathf.Sin(t) * Mathf.Sin(t) * Mathf.Sin(t);
            //targetPos.y = 13 * Mathf.Cos(t) - 5 * Mathf.Cos(t*2) - 2 * Mathf.Cos(t*3) - Mathf.Cos(4*t);
            this.transform.position = targetPos * radius + startpos;
            yield return null;
        }
    }

    [SerializeField] int count = 4;
    [SerializeField] float shootSpeed = 0.5f;

    IEnumerator ShootCircle()
    {
        Vector3 dir = Vector3.zero;
 
        for ( int c = 0; c < 20; c++)
        {
            for (int i = 0; i < count; i++)
            {
                Transform temp = ObjectPooling.instance.GetPool(PoolFlag.ebullet).transform;

                dir.z = (360 / count) * i;
                temp.eulerAngles = dir;
                temp.position = this.transform.position;
            }
            yield return new WaitForSeconds(shootSpeed);
        }

    }

    [SerializeField] float angle = 90;
    [SerializeField] float direction = 180;

    IEnumerator ShootAngle()
    {
        Vector3 dir = Vector3.zero;

        for (int c = 0; c < 20; c++)
        {
            for (int i = 0; i < count; i++)
            {
                Transform temp = ObjectPooling.instance.GetPool(PoolFlag.ebullet).transform;

                dir.z = (angle / (count - 1)) * i - (angle * 0.5f) + direction;
                temp.eulerAngles = dir;

                temp.position = this.transform.position;
            }
            yield return new WaitForSeconds(shootSpeed);
        }
    }
    [SerializeField] float angle2 = 5f;

    IEnumerator Stay()
    {
        Vector3 dir = Vector3.zero;

        for (int c = 0; c < 30; c++)
        {
            for (int i = -1; i != 3; i += 2)
            {
                Transform temp = ObjectPooling.instance.GetPool(PoolFlag.ebullet).transform;
                temp.position = this.transform.position;

                temp.up = player.position - temp.position;
                temp.Rotate(Vector3.forward * i * angle2);
            }
            yield return new WaitForSeconds(shootSpeed);
        }
    }

    IEnumerator Stay2()
    {
        Vector3 dir = Vector3.zero;

        float angle = 90;

        while (true)
        {
            if (angle > angle2)
            {
                angle -= 3f;
            }
            else if (angle < angle2)
            {
                angle = angle2;
            }
            else
            {
                break;
            }

            for (int i = -1; i != 3; i += 2)
            {
                Transform temp = ObjectPooling.instance.GetPool(PoolFlag.ebullet).transform;
                temp.position = this.transform.position;

                temp.up = player.position - temp.position;
                temp.Rotate(Vector3.forward * i * angle);
            }
            yield return new WaitForSeconds(shootSpeed);
        }
    }

    void Start()
    {


        StartCoroutine(Show());


        player = Gamemanager.instance.player.transform;
    }

    void Update()
    {

    }
}
