using UnityEngine;

public class Student : People
{
    private int grade;
    private string score;
    private string school;

    public void GoToSchool()
    {
        Debug.Log(this.name + " 이(가) 등교");
    }
 
}
