using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanktonSpawn : MonoBehaviour
{
    public float spawnWidth;
    public float spawnHeight;
    public GameObject planktonPrefab1;
    public GameObject planktonPrefab2;
    public GameObject planktonPrefab3;

    List<GameObject> prefabList = new List<GameObject>();


    private int numPlanktons = 0;
    public int maxPlanktons;

    public static PlanktonSpawn instance;

    // Use this for initialization
    void Start()
    {
        instance = this;

        prefabList.Add(planktonPrefab1);
        prefabList.Add(planktonPrefab2);
        prefabList.Add(planktonPrefab3);
        StartCoroutine(SpawnPlanktonsCoroutine());
    }

    IEnumerator SpawnPlanktonsCoroutine()
    {
        while (true)
        {
            if (numPlanktons < maxPlanktons)
            {
                int prefabIndex = Random.Range(0, 3);
                Vector3 spawnPosition = transform.position;
                spawnPosition += new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(-spawnHeight, spawnHeight), 0);
                Instantiate(prefabList[prefabIndex], spawnPosition, Quaternion.identity);
                numPlanktons++;
            }
            yield return new WaitForSeconds(Random.Range(1, 3));

        }
    }

    public void OnCollectPlankton()
    {
        numPlanktons--;
    }
}
