using System.Collections;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject spawnObject;

    public bool sedangSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(MunculkanObject());
    }

    void OnEnable()
    {
        StartCoroutine(MunculkanObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculkanObject()
    {
        while (sedangSpawn == true)
        {
            Instantiate(spawnObject, new Vector3(Random.Range(-5,5), 5 ,0), Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
