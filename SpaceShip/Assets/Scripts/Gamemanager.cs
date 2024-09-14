using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    [SerializeField] Player _player;

    public Player player
    { 
        get { return _player; }
        private set { }
        }


    [System.Serializable]

    public class SpwanPos
    {
        public Transform start;
        public Transform end;
    }

    [SerializeField] Transform enemyOriginal;

    [SerializeField] SpwanPos p1Pos;
    [SerializeField] SpwanPos p2Pos;
    [SerializeField] SpwanPos p3Pos;

    public int count = 10;

    void TopLine(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Transform enemy = ObjectPooling.instance.GetPool(PoolFlag.enemy).transform;
            //Transform enemy = Transform.Instantiate(enemyOriginal);
            enemy.position = Vector3.Lerp(p1Pos.start.position, p1Pos.end.position, (1.0f / (count - 1.0f)) * i);
        }
    }
    IEnumerator Pattern1()
    {
        //처음 생산시 2
        //5번 생산시 다음부터 1개씩 늘기
        //1  ~ 5  2개
        //6  ~ 10 3개
        //11 ~ 15 4개
        //16 ~ 20 5개
        //점점 늘어나도록
        //생산 주기 0.5초
        int count = 2;
        int num = 0;

        while (true)
        {

            TopLine(count);
            num++;

            if (num %5 == 0)
            {
                num = 0;
                count++;
            }

            yield return new WaitForSeconds(0.5f);


        }
    }

    IEnumerator Pattern2()
    {
        //스타트 부터 엔드까지 에너미 소환
        //순차적으로 소환
        //
        while (true)
        {

            for (int i = 0; i < count; i++)
            {
                Transform enemy = ObjectPooling.instance.GetPool(PoolFlag.enemy).transform;
                //Transform enemy = Transform.Instantiate(enemyOriginal);
                enemy.position = Vector3.Lerp(p2Pos.start.position, p2Pos.end.position, (1.0f / (count - 1.0f)) * i);
                enemy.up = Vector3.left;
                yield return new WaitForSeconds(0.5f);
            }
        }
    }

    IEnumerator Pattern3()
    {
        WaitForSeconds wfs = new WaitForSeconds(0.5f);
        while (true)
        {

            for (int i = 0; i < count; i++)
            {
                Transform enemy = ObjectPooling.instance.GetPool(PoolFlag.enemy).transform;
                //Transform enemy = Transform.Instantiate(enemyOriginal);
                enemy.position = Vector3.Lerp(p3Pos.start.position, p3Pos.end.position, (1.0f / (count - 1.0f)) * i);
                enemy.up = Vector3.right;
                yield return wfs;
            }
        }
    }

    private void Awake()
    { 
        instance = this;

        //StartCoroutine(Pattern3());
        //StartCoroutine(Pattern2());
    }
}
