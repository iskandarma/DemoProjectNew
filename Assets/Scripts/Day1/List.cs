using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField]
    List<Player> ListPlayer = new List<Player>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = ListPlayer.Find(element => element.Level > 5);
        Debug.Log(player.Name);
        bool isExist = ListPlayer.Exists(element => element.Level > 100);
        Debug.Log(isExist);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
