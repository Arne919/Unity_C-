using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject gameOverText;

    [SerializeField] GameObject originalEnemy;
    [SerializeField] Transform startPos;
    [SerializeField] Transform endPos;

    //[SerializeField] float spawnTime = 0.5f;

    private void Awake()
    {
        instance = this;
    }

    //IEnumerator Start()
    //{
    //    while (true)
    //    {
    //        GameObject temp = ObjectPooling.instance.GetPool(PoolObjIndex.Enemy);
    //        temp.transform.position = Vector3.Lerp(startPos.position, endPos.position, Random.Range(0f, 1f));
    //        temp.transform.rotation = Quaternion.Euler(0, 0, 180);
    //        yield return new WaitForSeconds(spawnTime);
    //    }
    //}

    public void GameOver()
    {
        gameOverText.SetActive(true);
    }

}
