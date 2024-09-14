using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : OnOFF
{

    [SerializeField]
    Transform endPosT;

    Vector3 startPos;
    //Vector3 endPos;

    [SerializeField]
    float speed;

    private void Awake()
    {
        startPos = transform.position;
        //endPos = endPosT.position;
    }


    Coroutine coru;

    IEnumerator Open()
    {
        float nowDistance = Vector3.Distance(transform.position, endPosT.position);
        float fullDistance = Vector3.Distance(startPos, endPosT.position);
        float t = 1 - nowDistance / fullDistance;


        while (t < 1)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, endPosT.position, t);
            yield return null;
        }
    }

    IEnumerator Close()
    {
        float nowDistance = Vector3.Distance(endPosT.position, transform.position);
        float fullDistance = Vector3.Distance(endPosT.position, startPos);
        float t = nowDistance / fullDistance;

        while (t < 1)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(endPosT.position, startPos, t);
            yield return null;
        }
    }

    void StopCoru()
    {
        if (coru != null)
        {
            StopCoroutine(coru);
        }
    }

    public override void Off()
    {
        StopCoru();
        coru = StartCoroutine(Close());
    }

    public override void On()
    {
        StopCoru();
        coru = StartCoroutine(Open());
    }
}
