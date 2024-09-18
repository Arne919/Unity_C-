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
        // Ű���� �Է����� �̵�
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        // �÷��̾��� �̵� ���⿡ ���� ȸ��
        RotatePlayer();

        transform.position += dir * moveSpeed * Time.deltaTime;

        // �÷��̾��� ���� ����
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
            return PlayerColor.White; // �⺻������ �Ͼ������ ����
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

    // �÷��̾ �̵��ϴ� �������� ȸ����Ű�� �Լ�
    void RotatePlayer()
    {
        if (dir.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90); // ������
        }
        else if (dir.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90); // ����
        }
        else if (dir.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // ����
        }
        else if (dir.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180); // �Ʒ���
        }
    }
}
