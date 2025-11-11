using NUnit.Framework.Interfaces;
using UnityEngine;

public class Loope : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int nyawa = 3;

        // Pengulangan While
        while (nyawa > 0)
        {
            nyawa--;
            Debug.Log(nyawa);
        }
        Debug.Log("Game Over");

        // Pengulangan For
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Pengulangan ke-" + i);
        }

        //Challange Faktorial
        Debug.Log("Hasil Faktorial " + Faktorial(3));
    
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int Faktorial(int angka)
    {
        int result =1;

        for (int i = angka; i > 0; i--)
        {
            result = result * i;
        }

        return result;

    }
}
