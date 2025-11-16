using UnityEngine;

public class DragObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnMouseEnter()
    // {
    //     Debug.Log("Enter");
    // }

    // void OnMouseDown()
    // {
    //     Debug.Log("Down");      
    // }

    void OnMouseDrag()
    {
        // Debug.Log("Drag");
        // Mengubah posisi mouse ke World point
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Posisi mouse yang sudah diubah ke world position disimpan dalam squarePosition
        Vector2 squarePosition = new Vector2(worldMousePosition.x, transform.position.y);

        // Posisi minimum layar setelah diubah ke world point disimpan di variable minimum
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));

        // Posisi maximum layar setelah diubah ke world point disimpan di variable maksimum
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0));

        // membatasi maximal sumbu X
        squarePosition.x = Mathf.Clamp(squarePosition.x, minimum.x, maximum.x);

        // mengubah posisi objek
        transform.position = squarePosition;     
    }

    // void OnMouseExit()
    // {
    //     Debug.Log("Exit");       
    // }
}
