using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Square : MonoBehaviour
{

    public ArahGerak arahGerak = ArahGerak.kanan;

    public float speed = 5.0f;

    public int score = 0;

    public int nyawa = 10;
    
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
            score++;
            Debug.Log("Score = " + score);
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
}

public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan
}
