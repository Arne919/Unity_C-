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
    public TileBase[] tiles; // �� Ÿ�� Ÿ�Կ� �ش��ϴ� Ÿ�� �迭
    public GameObject player;

    void Update()
    {
        //���콺 Ŭ��
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
        if (playerRotation == 0 || playerRotation == 360) // ����
            direction.y = 1;
        else if (playerRotation == 90 || playerRotation == -270) // ������
            direction.x = 1;
        else if (playerRotation == 180 || playerRotation == -180) // �Ʒ���
            direction.y = -1;
        else if (playerRotation == 270 || playerRotation == -90) // ����
            direction.x = -1;

        return currentPos + direction;
    }

    // Ÿ�� ���� �Լ�
    void ChangeTile(Vector3Int coordinate)
    {
        //Ÿ���� �ִ��� Ȯ��
        int currentTileType = GetTileType(coordinate);
        if (currentTileType == -1)
            return; // Ÿ���� ���� ��� return

        int nextTileType = (currentTileType + 1) % tiles.Length; // ���� Ÿ�� Ÿ�� ���
        tilemap.SetTile(coordinate, tiles[nextTileType]); // ���� Ÿ�Ϸ� ����
    }

    // ��ǥ�� �ش��ϴ� Ÿ�� Ÿ�� ��������
    int GetTileType(Vector3Int coordinate)
    {
        TileBase tile = tilemap.GetTile(coordinate);
        if (tile == null)
            return -1; // Ÿ���� ���� ��� -1 ��ȯ

        for (int i = 0; i < tiles.Length; i++)
        {
            if (tile == tiles[i])
            {
                return i;
            }
        }
        return -1; // Ÿ���� ���� ��� -1 ��ȯ
    }
}
