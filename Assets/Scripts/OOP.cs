using UnityEngine;


public class OOP : MonoBehaviour
{
    [SerializeField]
    Mobil mobil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Mobil mobil = new Mobil("Inova", "Toyota", "Hitam", 100);

        Debug.Log(mobil.Name);
        Debug.Log(mobil.Merk);
        Debug.Log(mobil.Warna);
        Debug.Log(mobil.Kecepatan);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
