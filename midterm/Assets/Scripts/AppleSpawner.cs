using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject xPosLow;
    public GameObject xPosHigh;


    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(xPosHigh.transform.position.x, xPosLow.transform.position.x), transform.position.y, transform.position.z);
            Instantiate(applePrefab, randomSpawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1, 6));
        }

    }
}
