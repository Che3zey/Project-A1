using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab; // Drag your Player prefab here

    void Start()
    {
        // Spawn the player at position (0,0,1) with no rotation
        Instantiate(playerPrefab, new Vector3(0, 0, 1), Quaternion.identity);
    }
}
