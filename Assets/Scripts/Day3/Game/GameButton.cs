using TMPro;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public Square square;

    /*
        Referensi ke komponen UI TextMeshPro (TMP_Text) yang digunakan
        untuk menampilkan skor di layar.
    */
    public TMP_Text score;

    /*
        Variabel integer untuk menyimpan nilai angka skor pemain.
        Nilai ini biasanya akan bertambah setiap kali pemain mendapatkan poin.
    */
    public int angkaSkor;

    /*
        Referensi ke komponen UI TextMeshPro (TMP_Text) lainnya,
        yang digunakan untuk menampilkan jumlah nyawa (life) pemain di layar.
    */
    public TMP_Text nyawa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // score.text = "Score : "+square.score;
        nyawa.text = "Nyawa : " + square.nyawa;
    }
    
    /*
        Fungsi untuk mengubah arah gerak objek Square ke kiri.
        variabel arahGerak di script Square akan diubah ke ArahGerak.kiri.
    */
    public void GerakKiri()
    {
        square.arahGerak = ArahGerak.kiri;
    }

    /*
        Fungsi untuk mengubah arah gerak objek Square ke Kanan.
        variabel arahGerak di script Square akan diubah ke ArahGerak.kanan.
    */
    public void GerakKanan()
    {
        square.arahGerak = ArahGerak.kanan;
    }

    /*
        Fungsi untuk mengubah arah gerak objek Square ke Atas.
        variabel arahGerak di script Square akan diubah ke ArahGerak.atas.
    */
    public void GerakAtas()
    {
        square.arahGerak = ArahGerak.atas;
    }
    
    /*
        Fungsi untuk mengubah arah gerak objek Square ke Bawah.
        variabel arahGerak di script Square akan diubah ke ArahGerak.bawah.
    */
    public void GerakBawah()
    {
        square.arahGerak = ArahGerak.bawah;    
    }
}
