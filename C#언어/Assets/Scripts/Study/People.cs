using UnityEngine;

public class People
{
    public string name;
    public int age;
    public float height;

    public void Eat()
    {
        Debug.Log(name + " 이(가) 먹음");
    }

    public void Sleep()
    {
        Debug.Log(name + " 이(가) 잠");
    }

    public void Study()
    {
        Debug.Log(name + " 이(가) 공부함");
    }
}
