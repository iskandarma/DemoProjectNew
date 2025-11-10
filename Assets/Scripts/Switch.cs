using UnityEngine;

public class Switch : MonoBehaviour
{
    int Id;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Id = 2;
        
        switch (Id)
        {
            case 1:
                Debug.Log("Basic Sword");
                break;
            case 2:
                Debug.Log("Electric Bow");
                break;
            case 3: 
                Debug.Log("Fire Spell");
                break;
            default:
                Debug.Log("Undifined");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
