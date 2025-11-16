using Unity.VisualScripting;
using UnityEngine;

public class PemainLompat : MonoBehaviour
{

    public bool diLantai;
    public float forceMultiplier = 7.0f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lompat()
    {
        if (diLantai)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = true;           
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = false;
        }
    }
}
