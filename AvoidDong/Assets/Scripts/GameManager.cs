using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //복제하여 생산
    [SerializeField] GameObject original;

    [SerializeField] Transform startPos;
    [SerializeField] Transform endPos;

    // Update is called once per frame
    void Update()
    {
        GameObject.Instantiate(original,Vector3.Lerp(startPos.position, endPos.position, Random.Range(0f,1f)), Quaternion.identity);

    }
}
