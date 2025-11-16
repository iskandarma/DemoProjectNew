using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int skor;
    public TMP_Text teksScore;

    public SquareMoveNew squareMoveNew;

    public GameObject bolaJatuh;

    public PemainLompat pemainLompat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTeksSkor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Klik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("posisi mouse ada di "+vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            // squareMoveNew.isMoveRight = false;
            // ToggleKiriKanan();
            // MunculDariAtas();
            pemainLompat.Lompat();

        }  
        
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("posisi mouse ada di "+vector.ToString());
            KurangSkor();
            UpdateTeksSkor();
            squareMoveNew.isMoveRight = true;
            // ToggleKiriKanan();
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Klik tengah");
            Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("posisi mouse ada di "+vector.ToString());
        }
    }

    void TambahSkor()
    {
        skor++;
        Debug.Log("Skor bertambah");
    }

    void KurangSkor()
    {
        skor--;
        Debug.Log("Skor berkurang");
    }

    void UpdateTeksSkor()
    {
        teksScore.text = skor.ToString();
        Debug.Log("Skor berubah");
    }

    void ToggleKiriKanan()
    {
        if (squareMoveNew.isMoveRight)
        {
            squareMoveNew.isMoveRight = !squareMoveNew.isMoveRight;
        } else
        {
            squareMoveNew.isMoveRight = !squareMoveNew.isMoveRight;            
        }
    }

    void MunculDariAtas()
    {
        // ambil posisi di mana kursor mouse berada
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //ambil posisi titik paling atas
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));

        //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);

        //memunculkan object dengan nama bola jatuh di posisi tempat jatuh dan dengan rotasi Quarternion identiry
        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);
    }

    void MunculDariSamping()
    {
        // ambil posisi di mana kursor mouse berada
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //ambil posisi titik paling kiri
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));

        //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);

        //memunculkan object dengan nama bola jatuh di posisi tempat jatuh dan dengan rotasi Quarternion identiry
        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);
    }
}
