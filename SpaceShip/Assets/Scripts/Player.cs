using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour, IOnHit
{
    [SerializeField] float speed = 3f;
    [SerializeField] GameObject original;
    [SerializeField] Transform[] bulletStartPos;

    [SerializeField] float shootSpeed;

    IEnumerator Shoot()
    {
        while (true) 
        {
            yield return new WaitForSeconds(shootSpeed);

            for (int i = 0; i < bulletStartPos.Length; i++)
            {
                GameObject temp = GameObject.Instantiate(original);
                temp.transform.position = bulletStartPos[i].position;
            }
        }
    }

    private void Awake()
    {
        //this.transform.up = Vector3.down;
        //this.transform.eulerAngles = Vector3.forward* 90;
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        this.transform.position += Vector3.right * x * Time.deltaTime * speed;        
    }

    public void OnHit(int d)
    {
        //gameObject.SetActive(false);
    }
}
