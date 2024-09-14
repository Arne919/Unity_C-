using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{

    [SerializeField] float speed = 4f;

    [SerializeField] float minSize = 0.7f;
    [SerializeField] float maxSize = 1.2f;

    [SerializeField] float minSpeed = 0.7f;
    [SerializeField] float maxSpeed = 1.2f;

    [SerializeField] Rigidbody2D rigid;

    float GetLevel()
    {
        float t = Gamemanager.instance.levelTime;

        if (t < 10)
            return 0.5f;
        else if (t < 20)
            return 1.0f;
        else
            return 1.2f;

    }

    private void Awake()
    {
        transform.localScale = Vector3.one * Random.Range(minSize, maxSize) * GetLevel();
        rigid.gravityScale = Random.Range(minSpeed, maxSpeed) * GetLevel();
    }

    void Update()
    {
        if (this.transform.position.y <= -6)
        {
            Gamemanager.instance.score++;
            Destroy(gameObject);
        }
        //this.transform.position += Vector3.down * Time.deltaTime * speed;
    }

    // -8 ~ +8 ·£´ý »ý¼º


}
