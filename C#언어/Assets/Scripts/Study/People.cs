using UnityEngine;

public class People
{
    public string name;
    public int age;
    public float height;

    public void Eat()
    {
        Debug.Log(name + " ��(��) ����");
    }

    public void Sleep()
    {
        Debug.Log(name + " ��(��) ��");
    }

    public void Study()
    {
        Debug.Log(name + " ��(��) ������");
    }
}
