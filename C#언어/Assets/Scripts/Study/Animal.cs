
using UnityEngine;

interface IWalk
{
    void Walk();
}

interface ISwim
{
    void Swim();
}

public class Animal
{
    public virtual void Eat()
    {
        Debug.Log("µøπ∞¿Ã ∏‘¿Ω");
    }
}
