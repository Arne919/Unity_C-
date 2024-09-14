using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small : MonoBehaviour, Iitem
{
    public void Use(Player target)
    {
        target.small.isOn = true;
    }
}
