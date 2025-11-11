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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
