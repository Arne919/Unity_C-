using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    //qwer �߿� �ϳ��� �����°�?
    //�Ű�� �����°�?


    public int skillindex = -1;

    // Update is called once per frame
    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        skillindex = -1;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            skillindex = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            skillindex = 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            skillindex = 2;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            skillindex = 3;
        }
    }
}
