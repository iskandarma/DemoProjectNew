using UnityEngine;

public class PlayerNampan : MonoBehaviour
{
    public bool isMove = false;

    public bool isMoveRight = true;

    public float speed = 7.0f;

    public GameObject nampanPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            nampanPlayer.transform.Translate(speed * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            nampanPlayer.transform.Translate(-speed * Time.deltaTime,0,0);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            Debug.Log("Nambrak Bola");
        }
    }
}
