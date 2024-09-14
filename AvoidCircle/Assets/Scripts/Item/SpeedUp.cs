using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour, Iitem
{
    public void Use(Player target)
    {
        target.speed *= 3;
    }


}
