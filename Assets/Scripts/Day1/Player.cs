using UnityEngine;

[System.Serializable]
public class Player
{
    public string Name;
    public int Level;
    public int Health;

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }
}
