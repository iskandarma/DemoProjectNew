using System.Collections;
using UnityEngine;

public class ContohCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // untuk menjalankan coroutine
        StartCoroutine(CobaCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Buat function IEnumerator untuk menggunkan coroutine
    IEnumerator CobaCoroutine()
    {
        Debug.Log("Perintah pertama");
        yield return new WaitForSeconds(5);
        Debug.Log("Perintah kedua");
    }
}
