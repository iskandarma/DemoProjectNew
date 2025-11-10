using UnityEngine;

public class Branch : MonoBehaviour
{
    int Age;
    int Money;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Age = 17;
        Money = 200000;

        if (Age >= 18 || Money > 100000)
        {
            Debug.Log("Bisa Masuk");
        } else
        {
            Debug.Log("Tidak Bisa Masuk");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
