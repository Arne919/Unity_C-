using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    [SerializeField] float speed = 3f;

    [SerializeField] int circleCount = 10;

    //부채꼴 각도
    [SerializeField] float buAngle = 90;
    //부채꼴 총알 발사 개수
    [SerializeField] int buCount = 10;
    //기준 각
    [SerializeField] float baseAngle = 0;
    [SerializeField] float spairalAngle = 5;
    [SerializeField] float shootSpeed = 0.01f;
    float currentAngle;

    private IEnumerator Start()
    {
        Vector3 startPos = new Vector3(0, 7.5f, 0);
        Vector3 endPos = new Vector3(0, 2.5f, 0);

        transform.position = startPos;
        while (this.transform.position.y > endPos.y)
        {
            yield return null;
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);   
        }
        transform.position = endPos;

        while (true)
        {
            float angle = buAngle / (buCount - 1);
            float startAngle = baseAngle - buAngle / 2;

            //for (int i = 0; i < buCount; i++)
            //{
            //    GameObject tempBullet = ObjectPooling.instance.GetPool(PoolObjIndex.EnemyBullet);
            //    tempBullet.transform.position = this.transform.position;
            //    tempBullet.transform.eulerAngles = Vector3.forward * (startAngle + angle * i);
            //}

            GameObject tempBullet = ObjectPooling.instance.GetPool(PoolObjIndex.EnemyBullet);
            tempBullet.transform.position = this.transform.position;
            tempBullet.transform.eulerAngles = Vector3.forward * currentAngle;

            currentAngle += spairalAngle;

            yield return new WaitForSeconds(shootSpeed);



        }




        //----------------------------------

        //for (int count = 0; count < 3; count++)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        GameObject tempBullet = ObjectPooling.instance.GetPool(PoolObjIndex.EnemyBullet);
        //        tempBullet.transform.position = this.transform.position;
        //        tempBullet.transform.up = Player.instance.transform.position - transform.position;
        //        tempBullet.transform.eulerAngles += Vector3.forward * Random.Range(10.0f, 350f);

        //        yield return new WaitForSeconds(0.1f);
        //    }
        //    yield return new WaitForSeconds(1f);
        //}


        //while (true)
        //{
        //    float angle = 360f / circleCount;
        //    for (int i = 0; i < circleCount; i++)
        //    {
        //        GameObject tempBullet = ObjectPooling.instance.GetPool(PoolObjIndex.EnemyBullet);
        //        tempBullet.transform.position = this.transform.position;
        //        tempBullet.transform.eulerAngles += Vector3.forward * i * angle;
        //    }
        //}
        //yield return new WaitForSeconds(0.5f);
    }



}
