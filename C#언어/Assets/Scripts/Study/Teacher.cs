using UnityEngine;

public class Teacher : People
{
    private string id;
    private string subject;

    public void GoToWork()
    {
        Debug.Log(this.name + " ��(��) ���");
    }
}
