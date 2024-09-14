using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpLimit : MonoBehaviour, Iitem
{
    public void Use(Player target)
    {
        target.fast.isOn = true;
        
    }
}
