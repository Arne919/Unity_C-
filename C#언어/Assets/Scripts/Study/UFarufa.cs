using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFarufa : Animal, ISwim, IWalk
{
    public void Swim()
    {
        Debug.Log("���ķ��� ����");
    }

    public void Walk()
    {
        Debug.Log("���ķ��� ����");
    }

}
