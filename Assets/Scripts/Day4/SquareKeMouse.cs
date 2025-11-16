using UnityEngine;

public class SquareKeMouse : MonoBehaviour
{

    public Transform CubeTransform;

    public Vector2 PosisiKlik;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Geser Object Ke Mouse
        // Debug.Log(Input.mousePosition);
        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Debug.Log(worldMousePosition);
        // CubeTransform.position = worldMousePosition;
        // CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, worldMousePosition, 0.3f);

        // Geser Object Ke Klik
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, PosisiKlik, 0.1f);
    }

}
