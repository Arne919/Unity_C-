using UnityEngine;

public class MyList<T>
{
    public T Value { get; set; }

    public void ShowValue()
    {
        Debug.Log(Value);
    }

    public void Test(T test)
    {
        Debug.Log(test);
    }

}
