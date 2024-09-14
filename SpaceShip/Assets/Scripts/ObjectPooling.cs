using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 어떤 오브젝트인가에 대한 enum
/// </summary>
public enum PoolFlag
{
    ebullet,
    enemy,
    pbullet
}
public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;

    /// <summary>
    /// 복제할 원본과 개수를 합친 클래스
    /// </summary>
    [System.Serializable]
    public class Original
    {
        public int initCount = 50;

        public GameObject obj;

    }

    //큐 들
    //큐를 가지는 리스트
    //게임 오브젝트를 가지는 큐
    //복제한 게임오브젝트를 담고있다
    List<Queue<GameObject>> qs = new List<Queue<GameObject>>();

    //원본 배열
    //배열로 만든 이유 인스펙터상에서 추가 제거 쉬워서
    public Original[] originals;

    /// <summary>
    /// qs초기화 함수
    /// 초기화
    /// </summary>
    private void Init()
    {
        //인스펙터에서 설정한 만큼 반복
        for (int i = 0; i < originals.Length; i++)
        {
            //리스트에 큐 추가하기
            qs.Add(new Queue<GameObject>());

            //오리지널의 i번 인덱스의 초기개수만큼 반복
            for (int j = 0; j < originals[i].initCount; j++)
            {
                //큐들의 i번인덱스 복제본 게임오브젝트 넣기
                qs[i].Enqueue(CreateObject(originals[i].obj));
            }
        }
    }

    /// <summary>
    /// 오브젝트 복제하기
    /// </summary>
    /// <param name="obj">복제할 원본</param>
    /// <returns></returns>
    private GameObject CreateObject(GameObject obj)
    {
        GameObject temp = GameObject.Instantiate(obj);
        temp.gameObject.SetActive(false);
        return temp;
    }

    /// <summary>
    /// 풀링에서 flag 인 오브젝트 달라
    /// </summary>
    /// <param name="f">어떤 오브젝트를 원하는가?</param>
    /// <returns>큐에 담겨있던 복제본</returns>
    public GameObject GetPool(PoolFlag f)
    {
        //enum을 int형 변환
        int index = (int)f;

        GameObject temp;

        //큐들의 index번 큐의 개수가 0이라면
        //해당 플래그의 오브젝트가 없다면
        if (qs[index].Count == 0)
            //해당 플래그 게임 오브젝트 생성하기
            temp = CreateObject(originals[index].obj);
        else
            //해당 플래그 게임오브젝트 큐에서 빼기
            temp = qs[index].Dequeue();

        temp.gameObject.SetActive(true);
        return temp;
    }



    /// <summary>
    /// 반환
    /// </summary>
    /// <param name="obj">반환할 오브젝트</param>
    /// <param name="f">오브젝트의 플래그</param>
    public void SetPool(GameObject obj, PoolFlag f)
    {
        int index = (int)f;
        obj.gameObject.SetActive(false);
        qs[index].Enqueue(obj);
    }

    private void Awake()
    {
        Init();
        instance = this;
    }
}
