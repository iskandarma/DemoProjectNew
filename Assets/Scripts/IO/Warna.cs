using UnityEngine;

public class Warna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
