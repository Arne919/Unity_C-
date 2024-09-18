using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;


public class JudgementLine : MonoBehaviour
{
    //나와 충돌한 상대방
    GameObject other;

    //출력되는 판정
    public TextMeshPro judgementText;

    public KeyCode key;

    public TextMeshPro scoreText;

    //public GameObject effect;
    private void Start()
    {
        //게임오브젝트 끄기
       gameObject.SetActive(false);
    }

    private void Update()
    {
        //충돌한 상대방이 있다면
        if (other != null)
        {

            if (Input.GetKeyDown(key))
            {
                //노트의 위치, 판정선의 위치 거리
                //                              판정선                     노트
                float dis = Vector3.Distance(this.transform.position, other.transform.position);

                if (dis < 0.25)
                {
                    judgementText.text = "Perfect";
                    GamemanagerRythm.instance.SetScore(5);
                    
                }
                else if (dis < 0.5)
                {
                    judgementText.text = "Great";
                    GamemanagerRythm.instance.SetScore(3);
                }
                else if (dis < 0.75)
                {
                    judgementText.text = "Good";
                    GamemanagerRythm.instance.SetScore(1);
                }
                else
                {
                    judgementText.text = "Bad";
                    GamemanagerRythm.instance.SetScore(-5);
                }
                //scoreText.text = GamemanagerRythm.score.ToString();
                GamemanagerRythm.instance.EffectPlay();
                Destroy(other);
            }
        }
    }




    //겹칠때(둘 중 하나라도 istrigger라면 실행)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        other = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        other = null;
    }
}