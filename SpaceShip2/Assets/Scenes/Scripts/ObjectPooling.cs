using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PoolObjIndex
{
    Bullet,
    Enemy,
    EnemyBullet
}

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;


    [System.Serializable]

    public struct PoolObj
    {
        public GameObject original;
        public int count;
    }

    public PoolObj[] obj;

    Queue<GameObject>[] queueS;

    private void Awake()
    {
        instance = this;
        queueS = new Queue<GameObject>[obj.Length];
        init();
    }

    //초기에 복제하여 큐에 넣는 함수
    void init()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            queueS[i] = new Queue<GameObject>();

            for(int count = 0; count < obj[i].count; count++)
            {
                queueS[i].Enqueue(CreateObj(i));
            }
        }
        //에너미 코드 완성
    }

    GameObject CreateObj(int index)
    {
        GameObject temp = Instantiate(obj[index].original, this.transform);
        temp.SetActive(false);

        return temp;
    }

    public GameObject GetPool(PoolObjIndex index)
    {
        GameObject temp;

        int i = (int)index;

        if (queueS[i].Count > 0)
        {
            temp = queueS[i].Dequeue();
        }
        else
        {
            temp = CreateObj(i);
        }
        temp.SetActive(true);
        temp.transform.SetParent(null);

        return temp;
    }

    public void SetPool(PoolObjIndex index, GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.SetParent(this.transform);
        queueS[(int)index].Enqueue(obj);
    }


    //public void SetPoolBullet(GameObject obj)
    //{
    //    obj.SetActive(false);
    //    bulletQ.Enqueue(obj);
    //}
}
