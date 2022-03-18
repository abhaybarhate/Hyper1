using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{

    [SerializeField] float spawnDuration = 5f;
    [SerializeField] float spawnDelay = 20f;
    [SerializeField] List<Item> spawnItems = new List<Item>();
    bool isStop = false;
    //[SerializeField] Item[] ItemsList = new Item[0];

    Vector3 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        isStop = true;
        StartCoroutine(SpawnItem());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnItem() {
        while(isStop) {
            int randomItemCount = Random.Range(0, spawnItems.Count);
            spawnItems[0].Spawn(DetermineSpawnLocation());
            spawnItems[0].ItemPrefab.transform.localScale = new Vector3(10,10,10);
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    Vector3 DetermineSpawnLocation() {
        return spawnLocation = new Vector3(Random.Range(-15f,15f), 0.5f, Random.Range(-6.4f, 7f));
        
    }

}
