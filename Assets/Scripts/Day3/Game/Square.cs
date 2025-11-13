using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Square : MonoBehaviour
{

    /*
        Variabel bertipe enum (ArahGerak) untuk menentukan arah gerak awal objek.
        Nilai default-nya adalah 'kanan'.
        Misalnya enum-nya seperti: enum ArahGerak { kiri, kanan, atas, bawah }
    */
    public ArahGerak arahGerak = ArahGerak.kanan;
    
    /*
    Kecepatan gerak objek dalam satuan unit per detik.
    Nilai float 5.0 berarti objek akan bergerak cukup cepat.
    */
    public float speed = 5.0f;

    /*
        Menyimpan jumlah skor pemain saat ini.
        Nilai awalnya 0 dan akan bertambah setiap kali pemain berhasil menabrak dinding.
    */
    public int score = 0;

    /*
        Menyimpan jumlah nyawa atau "life" pemain.
        Nilai awalnya 10 — bisa berkurang saat pemain terkena Bola.
    */
    public int nyawa = 10;

    /*
        Referensi ke script atau komponen lain bernama "GameButton"
        Dengan cara ini, kita bisa mengakses variabel atau fungsi yang ada di dalam GameButton   
    */
    public GameButton gameButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
                break;
        }
    }

    /*
        Fungsi ini akan otomatis dijalankan oleh Unity
        ketika objek yang memiliki script ini bersentuhan (collision)
        dengan objek lain yang punya Collider2D dan minimal salah satunya punya Rigidbody2D
    */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Kotak nambrak dinding");
            if (arahGerak == ArahGerak.atas)
            {
                arahGerak = ArahGerak.bawah;
            }
            else if (arahGerak == ArahGerak.bawah)
            {
                arahGerak = ArahGerak.atas;
            }
            else if (arahGerak == ArahGerak.kanan)
            {
                arahGerak = ArahGerak.kiri;
            }
            else
            {
                arahGerak = ArahGerak.kanan;
            }
            gameButton.angkaSkor++;
            TambahScore();
        }
        if (collision.gameObject.CompareTag("Bola"))
        {
            Debug.Log("Kotak nambrak Bola");
            nyawa--;
            Debug.Log("Nyawa = " + nyawa);
            if (nyawa < 1)
            {
                SceneManager.LoadScene("Day3GameOver");
            }
        }
    }

    // Fungsi ini bisa dipanggil dari script lain untuk menambah nilai score
    public void TambahScore()
    {
        gameButton.score.text = "Score : " + gameButton.angkaSkor.ToString();
    }
}

/*
    Enum ArahGerak digunakan untuk mendefinisikan kumpulan nilai tetap (konstan)
    yang mewakili arah gerakan dalam game 2D.
    Dengan enum ini, kamu bisa memilih arah seperti "atas", "bawah", "kiri", atau "kanan"
    tanpa harus pakai string atau angka mentah — lebih rapi dan mudah dibaca.
*/
public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan
}
