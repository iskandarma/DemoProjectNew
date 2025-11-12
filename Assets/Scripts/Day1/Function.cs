using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int hasilPerkalian = perkalian(2, 3, 5);
        Debug.Log("Hasil perkalian = " + hasilPerkalian);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public int perkalian (int angka1, int angka2, int angka3)
    {
        return angka1 * angka2 * angka3;
    }
}
