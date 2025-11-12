using UnityEngine;

[System.Serializable]
public class Mobil
{
    public string Name;
    public string Merk;
    public string Warna;
    public int Kecepatan;

    public Mobil(string name, string merk, string warna, int kecepatan)
    {
        Name = name;
        Merk = merk;
        Warna = warna;
        Kecepatan = kecepatan;
    }

}
