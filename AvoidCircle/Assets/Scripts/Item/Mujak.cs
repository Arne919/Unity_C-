using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mujak : MonoBehaviour, Iitem
{
    public void Use(Player target)
    {
        target.mujak.isOn = true;
    }

}
