using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField]
    public string[] ArrayName;
    public Mobil[] Mobils;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < ArrayName.Length; i++)
        {
            Debug.Log(ArrayName[i]);
        }

        foreach (string name in ArrayName)
        {
            Debug.Log(name);
        }
        
        foreach (Mobil mobil in Mobils)
        {
            Debug.Log(mobil.Name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
