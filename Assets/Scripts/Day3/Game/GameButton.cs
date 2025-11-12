using TMPro;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public Square square;

    public TMP_Text score;

    public TMP_Text nyawa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : "+square.score;
        nyawa.text = "Nyawa : "+square.nyawa;
    }

    public void GerakKiri()
    {
        square.arahGerak = ArahGerak.kiri;
    }

    public void GerakKanan()
    {
        square.arahGerak = ArahGerak.kanan;
    }

    public void GerakAtas()
    {
        square.arahGerak = ArahGerak.atas;
    }
    
    public void GerakBawah()
    {
        square.arahGerak = ArahGerak.bawah;    
    }
}
