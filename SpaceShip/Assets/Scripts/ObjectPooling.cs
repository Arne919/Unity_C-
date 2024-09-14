using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// � ������Ʈ�ΰ��� ���� enum
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
    /// ������ ������ ������ ��ģ Ŭ����
    /// </summary>
    [System.Serializable]
    public class Original
    {
        public int initCount = 50;

        public GameObject obj;

    }

    //ť ��
    //ť�� ������ ����Ʈ
    //���� ������Ʈ�� ������ ť
    //������ ���ӿ�����Ʈ�� ����ִ�
    List<Queue<GameObject>> qs = new List<Queue<GameObject>>();

    //���� �迭
    //�迭�� ���� ���� �ν����ͻ󿡼� �߰� ���� ������
    public Original[] originals;

    /// <summary>
    /// qs�ʱ�ȭ �Լ�
    /// �ʱ�ȭ
    /// </summary>
    private void Init()
    {
        //�ν����Ϳ��� ������ ��ŭ �ݺ�
        for (int i = 0; i < originals.Length; i++)
        {
            //����Ʈ�� ť �߰��ϱ�
            qs.Add(new Queue<GameObject>());

            //���������� i�� �ε����� �ʱⰳ����ŭ �ݺ�
            for (int j = 0; j < originals[i].initCount; j++)
            {
                //ť���� i���ε��� ������ ���ӿ�����Ʈ �ֱ�
                qs[i].Enqueue(CreateObject(originals[i].obj));
            }
        }
    }

    /// <summary>
    /// ������Ʈ �����ϱ�
    /// </summary>
    /// <param name="obj">������ ����</param>
    /// <returns></returns>
    private GameObject CreateObject(GameObject obj)
    {
        GameObject temp = GameObject.Instantiate(obj);
        temp.gameObject.SetActive(false);
        return temp;
    }

    /// <summary>
    /// Ǯ������ flag �� ������Ʈ �޶�
    /// </summary>
    /// <param name="f">� ������Ʈ�� ���ϴ°�?</param>
    /// <returns>ť�� ����ִ� ������</returns>
    public GameObject GetPool(PoolFlag f)
    {
        //enum�� int�� ��ȯ
        int index = (int)f;

        GameObject temp;

        //ť���� index�� ť�� ������ 0�̶��
        //�ش� �÷����� ������Ʈ�� ���ٸ�
        if (qs[index].Count == 0)
            //�ش� �÷��� ���� ������Ʈ �����ϱ�
            temp = CreateObject(originals[index].obj);
        else
            //�ش� �÷��� ���ӿ�����Ʈ ť���� ����
            temp = qs[index].Dequeue();

        temp.gameObject.SetActive(true);
        return temp;
    }



    /// <summary>
    /// ��ȯ
    /// </summary>
    /// <param name="obj">��ȯ�� ������Ʈ</param>
    /// <param name="f">������Ʈ�� �÷���</param>
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
