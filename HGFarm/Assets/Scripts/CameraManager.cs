using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera; // 메인 카메라
    public Camera map1Camera; // 맵1 카메라
    public Camera map2Camera; // 맵2 카메라

    void Start()
    {
        // 메인 카메라 활성화
        mainCamera.gameObject.SetActive(true);
        map1Camera.gameObject.SetActive(false);
        map2Camera.gameObject.SetActive(false);
    }

    void Update()
    {
        // 플레이어의 x축 위치를 확인하여 맵 카메라를 활성화
        if (transform.position.x >= 9)
        {
            mainCamera.gameObject.SetActive(false);
            map1Camera.gameObject.SetActive(true); // 맵1 카메라 활성화
            map2Camera.gameObject.SetActive(false);
        }
        else if (transform.position.x <= -9)
        {
            mainCamera.gameObject.SetActive(false);
            map1Camera.gameObject.SetActive(false);
            map2Camera.gameObject.SetActive(true); // 맵2 카메라 활성화
        }
        else
        {
            // 그 외 기본 카메라를 활성화
            mainCamera.gameObject.SetActive(true); // 메인 카메라 활성화
            map1Camera.gameObject.SetActive(false);
            map2Camera.gameObject.SetActive(false);
        }
    }
}
