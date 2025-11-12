using TMPro;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public TMP_Text tMP_Text;

    public TMP_Text listWarna;

    public DatabaseWarna databaseWarna;

    public int index = 0;

    public GameObject SquareUbahWarna;

    public SquareMove squareMove;

    void Start()
    {
        listWarna.text = databaseWarna.ListWarna[index];
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Kanan()
    {
        tMP_Text.text = "Kanan";
    }

    public void Kiri()
    {
        tMP_Text.text = "Kiri";
    }

    public void Next()
    {
        if (index >= databaseWarna.ListWarna.Count - 1)
        {
            index = 0;
        }
        else
        {
            index = index + 1;
        }

        listWarna.text = databaseWarna.ListWarna[index];

    }

    public void Prev()
    {
        if (index <= 0)
        {
            index = databaseWarna.ListWarna.Count - 1;
        }
        else
        {
            index = index - 1;
        }
        listWarna.text = databaseWarna.ListWarna[index];
    }

    public void UbahWarna(Color warna)
    {
        SpriteRenderer spriteRenderer = SquareUbahWarna.GetComponent<SpriteRenderer>();
        spriteRenderer.color = warna;
    }

    public void UbahWarnaMerah()
    {
        UbahWarna(Color.red);
    }

    public void UbahWarnaBiru()
    {
        UbahWarna(Color.blue);
    }

    public void UbahWarnaGreen()
    {
        UbahWarna(Color.green);
    }

    public void UbahWarnaAcak()
    {
        Color acak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        UbahWarna(acak);
    }

    public void Mulai()
    {
        squareMove.isMove = true;
    }

    public void Berhenti()
    {
        squareMove.isMove = false;
    }

    public void GerakKanan()
    {
        squareMove.isMoveRight = true;
    }
    
    public void GerakKiri()
    {
        squareMove.isMoveRight = false;
    }
}

