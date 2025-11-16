using System.Collections;
using UnityEngine;

public class PenghapusObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(HapusObject());
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HapusObject()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
