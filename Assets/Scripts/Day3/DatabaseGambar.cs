using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DatabaseGambar", menuName = "Scriptable Objects/DatabaseGambar")]
public class DatabaseGambar : ScriptableObject
{
    public List<Sprite> ListGambar = new List<Sprite>();
}
