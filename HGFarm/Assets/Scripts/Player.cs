using UnityEngine;

public enum PlayerColor
{
    Red,
    Blue,
    Yellow,
    Green,
    White
}

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Vector3 dir;
    public SpriteRenderer playerSpriteRenderer;

    void Update()
    {
        // 키보드 입력으로 이동
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        // 플레이어의 이동 방향에 따라 회전
        RotatePlayer();

        transform.position += dir * moveSpeed * Time.deltaTime;

        // 플레이어의 색상 변경
        PlayerColor playerColor = GetPlayerColor();
        ChangePlayerColor(playerColor);
    }

    PlayerColor GetPlayerColor()
    {
        if (Input.GetKey(KeyCode.W))
            return PlayerColor.Red;
        else if (Input.GetKey(KeyCode.S))
            return PlayerColor.Blue;
        else if (Input.GetKey(KeyCode.D))
            return PlayerColor.Yellow;
        else if (Input.GetKey(KeyCode.A))
            return PlayerColor.Green;
        else
            return PlayerColor.White; // 기본적으로 하얀색으로 설정
    }

    void ChangePlayerColor(PlayerColor color)
    {
        switch (color)
        {
            case PlayerColor.Red:
                playerSpriteRenderer.color = Color.red;
                break;
            case PlayerColor.Blue:
                playerSpriteRenderer.color = Color.blue;
                break;
            case PlayerColor.Yellow:
                playerSpriteRenderer.color = Color.yellow;
                break;
            case PlayerColor.Green:
                playerSpriteRenderer.color = Color.green;
                break;
        }
    }

    // 플레이어를 이동하는 방향으로 회전시키는 함수
    void RotatePlayer()
    {
        if (dir.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90); // 오른쪽
        }
        else if (dir.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90); // 왼쪽
        }
        else if (dir.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // 위쪽
        }
        else if (dir.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180); // 아래쪽
        }
    }
}
