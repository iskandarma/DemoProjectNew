using UnityEngine;

public class TabrakWarna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bola tabrak dengan bola");
        SpriteRenderer _spriteRenderer;

        _spriteRenderer = GetComponent<SpriteRenderer>();

        Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        _spriteRenderer.color = warnaAcak;
    }
}
