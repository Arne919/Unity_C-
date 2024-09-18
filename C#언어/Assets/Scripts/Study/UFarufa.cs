using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFarufa : Animal, ISwim, IWalk
{
    public void Swim()
    {
        Debug.Log("우파루파 수영");
    }

    public void Walk()
    {
        Debug.Log("우파루파 걸음");
    }

}
