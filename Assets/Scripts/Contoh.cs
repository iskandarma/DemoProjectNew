using UnityEngine;

public class Contoh : MonoBehaviour
{
    int Number1 = 10;
    int Number2 = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int Temp;

        Temp = Number1;
        Number1 = Number2;
        Number2 = Temp;

        Debug.Log("Number1 = "+Number1);
        Debug.Log("Number2 = "+Number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
