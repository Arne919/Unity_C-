using UnityEngine;

public class Rabbit : Animal, IWalk
{
    public void Walk()
    {
        Debug.Log("�䳢�� ����");
    }

    public override void Eat()
    {
        Debug.Log("�䳢�� ����");
    }
}
