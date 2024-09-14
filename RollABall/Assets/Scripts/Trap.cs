using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : OnOFF
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Time.timeScale = 0;
            Debug.Log("게임오버~");
        }
    }

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

    public override void On()
    {
        StartCoroutine(Open());
    }

}
