using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera; // ���� ī�޶�
    public Camera map1Camera; // ��1 ī�޶�
    public Camera map2Camera; // ��2 ī�޶�

    void Start()
    {
        // ���� ī�޶� Ȱ��ȭ
        mainCamera.gameObject.SetActive(true);
        map1Camera.gameObject.SetActive(false);
        map2Camera.gameObject.SetActive(false);
    }

    void Update()
    {
        // �÷��̾��� x�� ��ġ�� Ȯ���Ͽ� �� ī�޶� Ȱ��ȭ
        if (transform.position.x >= 9)
        {
            mainCamera.gameObject.SetActive(false);
            map1Camera.gameObject.SetActive(true); // ��1 ī�޶� Ȱ��ȭ
            map2Camera.gameObject.SetActive(false);
        }
        else if (transform.position.x <= -9)
        {
            mainCamera.gameObject.SetActive(false);
            map1Camera.gameObject.SetActive(false);
            map2Camera.gameObject.SetActive(true); // ��2 ī�޶� Ȱ��ȭ
        }
        else
        {
            // �� �� �⺻ ī�޶� Ȱ��ȭ
            mainCamera.gameObject.SetActive(true); // ���� ī�޶� Ȱ��ȭ
            map1Camera.gameObject.SetActive(false);
            map2Camera.gameObject.SetActive(false);
        }
    }
}
