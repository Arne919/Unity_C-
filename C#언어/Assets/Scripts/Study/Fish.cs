using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal, ISwim
{
    public void Swim()
    {
        Debug.Log("����Ⱑ ����");
    }
}
