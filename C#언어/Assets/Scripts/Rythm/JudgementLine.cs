using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;


public class JudgementLine : MonoBehaviour
{
    //���� �浹�� ����
    GameObject other;

    //��µǴ� ����
    public TextMeshPro judgementText;

    public KeyCode key;

    public TextMeshPro scoreText;

    //public GameObject effect;
    private void Start()
    {
        //���ӿ�����Ʈ ����
       gameObject.SetActive(false);
    }

    private void Update()
    {
        //�浹�� ������ �ִٸ�
        if (other != null)
        {

            if (Input.GetKeyDown(key))
            {
                //��Ʈ�� ��ġ, �������� ��ġ �Ÿ�
                //                              ������                     ��Ʈ
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




    //��ĥ��(�� �� �ϳ��� istrigger��� ����)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        other = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        other = null;
    }
}