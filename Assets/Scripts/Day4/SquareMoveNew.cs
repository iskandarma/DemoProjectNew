using UnityEngine;

public class SquareMoveNew : MonoBehaviour
{

    public bool isMove = true;
    public bool isMoveRight = true;

    public float speed = 5.0f;

    public GameManager gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoveRight == true)
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        } else
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }


}
