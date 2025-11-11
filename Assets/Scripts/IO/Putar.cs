using UnityEngine;

public class Putar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(50 * Time.deltaTime, 50 * Time.deltaTime, 50 * Time.deltaTime);
    }
}
