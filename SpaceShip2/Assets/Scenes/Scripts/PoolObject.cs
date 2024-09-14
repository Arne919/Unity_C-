using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    [SerializeField] PoolObjIndex index;

    //오브젝트 사용이 다 끝났을 때
    //풀에 넣어 주게끔 주는 함수

    public void ReturnObject()
    {
        ObjectPooling.instance.SetPool(index, this.gameObject);
    }

}
