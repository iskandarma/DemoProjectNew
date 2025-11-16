using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Waktu;

    public TMP_Text TextTimer;

    public float MaximumWaktu;

    public bool WaktuBerjalan=true;

    public KeyCode StartCoroutineKey;
    
    public KeyCode StopCoroutineKey;

    public Coroutine HitungTimerCoroutine;

    public Image ProgressFill;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(HitungTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(StartCoroutineKey))
        {
            if(HitungTimerCoroutine == null)
            {
                HitungTimerCoroutine = StartCoroutine(HitungTimer());
            }
        }

        if (Input.GetKeyDown(StopCoroutineKey))
        {
            if (HitungTimerCoroutine != null)
            {
                StopCoroutine(HitungTimerCoroutine);
                HitungTimerCoroutine = null;
            }
        }
    }

    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan==true && Waktu < MaximumWaktu)
        {
            Waktu = Waktu + 1;
            TextTimer.text = Waktu.ToString();
            ProgressFill.fillAmount = Waktu / MaximumWaktu;
            yield return new WaitForSeconds(1);
        }
    }
}
