using UnityEngine;

public class CekInputDetection : MonoBehaviour
{
    public GameObject _munculHilang;

    public GameObject _untukSpawn;

    public GameObject _capsuleBerwarna;

    public GameObject _nampanKotak;

    public int posisiX = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("Tombol panah kiri dipencet");
            _nampanKotak.transform.Translate(posisiX, 0, 0);
            posisiX++;
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Tombol panah kanan dipencet");
            
        }

        

    }
}
