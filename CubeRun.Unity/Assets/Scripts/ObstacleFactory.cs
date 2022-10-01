using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactory : MonoBehaviour
{

    public List<GameObject> obstacleTunnelPrefabs;

    private bool mShouldSpawnObstacles = true;

    private GameManager gameManager;

    public Transform SpawnPosition;


    private void Start()
    {
        this.gameManager = GameObject.FindObjectOfType<GameManager>();
        StartCoroutine("ManageObstacleSpawning");
    }

    private IEnumerator ManageObstacleSpawning()
    {
        if (!gameManager.IsGameOver)
        {
            Debug.Log("Spawning obstacles");
            float randomDelay = Random.Range(1, 5);
            yield return new WaitForSeconds(randomDelay);
            this.SpawnObstacles();
            yield return ManageObstacleSpawning();
        }
        else
        {
            yield return null;
        }
    }


    public void StopSpawningObstacles()
    {
        this.mShouldSpawnObstacles = false;
    }

    private void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, this.obstacleTunnelPrefabs.Count - 1);
        var prefab = this.obstacleTunnelPrefabs[randomIndex];
        GameObject.Instantiate(original: prefab, position: SpawnPosition.transform.position, rotation: new Quaternion());
    }

}
