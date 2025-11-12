using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public bool isMoveRight = true;
    public float speed = 5.0f;
    public bool isMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            if (isMoveRight)
            {
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            } else
            {
                gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        } else
        {
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
