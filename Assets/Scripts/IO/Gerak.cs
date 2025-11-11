using UnityEngine;

public class Gerak : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public bool isMoveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight)
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kotak bertabrakan");
        if (isMoveRight)
        {
            isMoveRight = false;
        } else
        {
            isMoveRight = true;
        }
    }
    
}
