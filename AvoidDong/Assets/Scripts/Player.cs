using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 3;

    float maxRight = 8f;
    float maxLeft = -8f;

    // Update is called once per frame
    void Update()
    {


        if(this.transform.position.x <= maxLeft) //��
        {
            this.transform.position = new Vector3(maxLeft, this.transform.position.y, 0);

        }

        else if (this.transform.position.x > maxRight) //����
        {
            this.transform.position = new Vector3(maxRight, this.transform.position.y, 0);

        }
        else
        {
            float h = Input.GetAxis("Horizontal"); //����
            float v = Input.GetAxis("Vertical"); //����

            transform.position += new Vector3(h, v, 0) * Time.deltaTime * speed;
        }
    
    }

}
