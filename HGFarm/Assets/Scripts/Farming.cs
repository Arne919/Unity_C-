using UnityEngine;
using UnityEngine.Tilemaps;

public enum TileType
{
    Watered,
    Plowed,
    Seed,
    Sprout,
    Mature,
    Harvested

}

public class Farming : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase[] tiles; // 각 타일 타입에 해당하는 타일 배열
    public GameObject player;

    void Update()
    {
        //마우스 클릭
        if (Input.GetMouseButtonDown(0))
        {
            Vector3Int playerPos = tilemap.WorldToCell(player.transform.position);
            Vector3Int targetCoordinate = GetNextTile(playerPos, player.transform.rotation.eulerAngles.z);
            ChangeTile(targetCoordinate);
        }
    }

    Vector3Int GetNextTile(Vector3Int currentPos, float playerRotation)
    {
        Vector3Int direction = Vector3Int.zero;
        if (playerRotation == 0 || playerRotation == 360) // 위쪽
            direction.y = 1;
        else if (playerRotation == 90 || playerRotation == -270) // 오른쪽
            direction.x = 1;
        else if (playerRotation == 180 || playerRotation == -180) // 아래쪽
            direction.y = -1;
        else if (playerRotation == 270 || playerRotation == -90) // 왼쪽
            direction.x = -1;

        return currentPos + direction;
    }

    // 타일 변경 함수
    void ChangeTile(Vector3Int coordinate)
    {
        //타일이 있는지 확인
        int currentTileType = GetTileType(coordinate);
        if (currentTileType == -1)
            return; // 타일이 없는 경우 return

        int nextTileType = (currentTileType + 1) % tiles.Length; // 다음 타일 타입 계산
        tilemap.SetTile(coordinate, tiles[nextTileType]); // 다음 타일로 변경
    }

    // 좌표에 해당하는 타일 타입 가져오기
    int GetTileType(Vector3Int coordinate)
    {
        TileBase tile = tilemap.GetTile(coordinate);
        if (tile == null)
            return -1; // 타일이 없는 경우 -1 반환

        for (int i = 0; i < tiles.Length; i++)
        {
            if (tile == tiles[i])
            {
                return i;
            }
        }
        return -1; // 타일이 없는 경우 -1 반환
    }
}
