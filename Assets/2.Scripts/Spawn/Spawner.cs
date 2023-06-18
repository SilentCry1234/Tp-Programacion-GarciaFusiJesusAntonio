using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] spawns; 
    [SerializeField] float spawnTime;
    [SerializeField] float spawnRate;

    [SerializeField] private Collectibles collectibles;

    private void Start()
    {
        InvokeRepeating("CreateCollectibles", spawnTime, spawnRate);
    }

    private void CreateCollectibles()
    {
        for(int i = 0; i < collectibles.CollectibleList.Count; i++)
        {
            int randomIndex = Random.Range(0, spawns.Length);
            Vector3 randomLocation = spawns[randomIndex].position;

            Instantiate(collectibles.CollectibleList[i], randomLocation, Quaternion.identity);;
        }
    }
}
