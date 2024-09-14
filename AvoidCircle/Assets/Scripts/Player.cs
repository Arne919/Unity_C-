using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public class itemInfo
    {
        public itemInfo(float _maxTime)
        {
            maxTime = _maxTime;
            remainTime = 0;
            IsOn = false;
        }

        public float remainTime;
        public float maxTime;
        bool IsOn;
        public bool isOn
        {
            get { return IsOn; }
            set
            {
                IsOn = value;
                if (value )
                {
                    remainTime = maxTime;
                }
            }
        }
    }



    Vector3 mov = Vector3.zero;
    public float speed = 3f;
    const float MAX_POS = 8.35f; //����
    //float myPosX;
    Vector3 targetPos;//������ ������� ������ ��ġ

    public itemInfo fast = new itemInfo(1f);
    public itemInfo mujak = new itemInfo(3f);
    public itemInfo small = new itemInfo(5f);

    SpriteRenderer sr;


    //������ ȹ��� ���ʵ��� ���������ΰ�
    float fastTime = 3;
    //�̼Ӿ� ���� �ð�:
    float remainFast = 0;

    private void Awake()
    {
        //y���� z�� �ʱ�ȭ �� 
        targetPos = this.transform.position;
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    //int Run()
    //{
    //    if (Input.GetKey(KeyCode.LeftShift))
    //        return 2;
    //    return 1;

    //}

    /// <summary>
    /// ������ ������ ���� �ð��� �����ִٸ�
    /// �����ϵ���
    /// </summary>
    void ItemInfoTime(itemInfo info)
    {
        if (info.isOn)
        {
            info.remainTime -= Time.deltaTime;

            if (info.remainTime < 0)
            {
                info.isOn = false;
            }
        }
    }

    int OnFast()
    {
        ItemInfoTime(fast);
        if (fast.isOn)
            return 3;
        return 1;
    }

    void OnMujak()
    {
        ItemInfoTime(mujak);
        //sr.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        if (mujak.isOn)
            sr.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        else
            sr.color = Color.white;
    }

    Vector3 minScale = Vector3.one * 0.3f;

    void OnSmall()
    {
        ItemInfoTime(small);

        transform.localScale = small.isOn? minScale : Vector3.one;
    }

    private void Move()
    {

        //������ ��ġ(������)     ����x��ġ     + (        �����ϰŸ�                                )
        targetPos.x = this.transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed * OnFast();
        //targetPos.x = this.transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed * Run() * OnFast();

        //�����Ұ� x = clamp (�����Ұ�, ���� ��, ������ ��);
        //������ ��ġ (������) clamp -> �����۾�
        targetPos.x = Mathf.Clamp(targetPos.x, -MAX_POS, MAX_POS);

        //mov.x = ������ x ��ġ
        //mov.y = ����ġ
        //����ġ = mov;
        this.transform.position = targetPos;
    }

    void Update()
    {
        Move();
        OnSmall();
        OnMujak();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            if (mujak.isOn)
                return;
            Gamemanager.instance.GameOver();
        }
        else if (collision.tag == "Item")
        {
            //collision.GetComponent<Iitem>().Use(this);

            Iitem[] arr = collision.GetComponents<Iitem>();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Use (this);
            }
            //Ǯ��ڸ� ��
            //Iitem abc = collision.GetComponent<Iitem>();
            //abc.Use(this);
            collision.gameObject.SetActive(false);
        }  
    }


}
