using UnityEngine;

public class CekInputDetection : MonoBehaviour
{
    public GameObject _munculHilang;

    public GameObject _untukSpawn;

    public GameObject _capsuleBerwarna;

    public GameObject _nampanKotak;

    float kecepatan = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = 0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol Spasi dipencet");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O dipencet");
            _munculHilang.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P dipencet");
            _munculHilang.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter dipencet");
            // Instantiate(_untukSpawn);

            // Vector3 spawnPosition = new Vector3(2, 2, 0);
            // Quaternion spawnRotaion = Quaternion.Euler(0, 0, 0);
            // Instantiate(_untukSpawn, spawnPosition, spawnRotaion);

            Instantiate(_untukSpawn, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.Euler(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("Tombol Hapus dipencet");
            GameObject hancurkan = GameObject.FindGameObjectWithTag("sasaran");
            Destroy(hancurkan);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Tombol C dipencet");
            SpriteRenderer _spriteRenderer = _capsuleBerwarna.GetComponent<SpriteRenderer>();
            Color acak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _spriteRenderer.color = acak;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Tombol panah kiri dipencet");
            moveX = -1f;
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Tombol panah kanan dipencet");
            moveX = 1f;
        }
        
        if (moveX != 0)
        {
            _nampanKotak.transform.Translate(moveX * kecepatan * Time.deltaTime, 0, 0);
        }

        

    }
}
