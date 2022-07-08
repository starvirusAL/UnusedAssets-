using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTile : MonoBehaviour
{

    [SerializeField] GameObject[] tilePrefabs;
    private float spawnPos = 30;
    private float tileLength = 30;
    int tileStart = 3;
    [SerializeField] Transform player;
    void Start()
    {
        for (int i = 0; i< tileStart; i++)
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    void Update()
    {
        if (player.position.z > spawnPos - (tileStart * tileLength)) { SpawnTile(Random.Range(0, tilePrefabs.Length)); }
            
    }

    private void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        spawnPos += tileLength;
    }
}
