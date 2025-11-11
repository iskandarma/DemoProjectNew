using UnityEngine;

public class Loope : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int nyawa = 10;

        while (nyawa > 0)
        {
            nyawa--;
            Debug.Log(nyawa);
        }
        Debug.Log("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
