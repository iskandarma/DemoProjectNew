using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AksiTombol : MonoBehaviour
{
    // Sprite adalah asset gambar yang ingin dimasukkan ke object image
    // public Sprite assetGambar;

    // Image adalah component dari object image yang ada di dalam scene
    // public Image image;

    // TMP_Text adalah component untuk mengganti text
    // public TMP_Text objectText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AksiNewGame()
    {

        // Mengubah gambar
        // image.sprite = assetGambar;

        //Mengubah Text
        // objectText.text = "2";

        SceneManager.LoadScene("Day3NewGame");
        Debug.Log("Tombol diclick");
    }

    public void AksiBack()
    {
        SceneManager.LoadScene("Day3UI");
        Debug.Log("Tombol diclick");
    }
}
