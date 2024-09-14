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
    const float MAX_POS = 8.35f; //범위
    //float myPosX;
    Vector3 targetPos;//범위를 벗어났을때 가야할 위치

    public itemInfo fast = new itemInfo(1f);
    public itemInfo mujak = new itemInfo(3f);
    public itemInfo small = new itemInfo(5f);

    SpriteRenderer sr;


    //아이템 획득시 몇초동안 빨라질것인가
    float fastTime = 3;
    //이속업 남은 시간:
    float remainFast = 0;

    private void Awake()
    {
        //y값과 z값 초기화 용 
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
    /// 아이템 인포에 대해 시간이 남아있다면
    /// 감소하도록
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

        //가야할 위치(보정전)     현재x위치     + (        움직일거리                                )
        targetPos.x = this.transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed * OnFast();
        //targetPos.x = this.transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed * Run() * OnFast();

        //가야할곳 x = clamp (가야할곳, 왼쪽 끝, 오른쪽 끝);
        //가야할 위치 (보정후) clamp -> 보정작업
        targetPos.x = Mathf.Clamp(targetPos.x, -MAX_POS, MAX_POS);

        //mov.x = 가야할 x 위치
        //mov.y = 현위치
        //현위치 = mov;
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
            //풀어쓰자면 ↓
            //Iitem abc = collision.GetComponent<Iitem>();
            //abc.Use(this);
            collision.gameObject.SetActive(false);
        }  
    }


}
