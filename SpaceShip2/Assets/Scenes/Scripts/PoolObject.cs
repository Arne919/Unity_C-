using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    [SerializeField] PoolObjIndex index;

    //������Ʈ ����� �� ������ ��
    //Ǯ�� �־� �ְԲ� �ִ� �Լ�

    public void ReturnObject()
    {
        ObjectPooling.instance.SetPool(index, this.gameObject);
    }

}
