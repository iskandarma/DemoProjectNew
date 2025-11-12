using UnityEngine;
using UnityEngine.Events;

public class PendeteksiInputUnity : MonoBehaviour
{
    // public Score objectScore;

    public UnityEvent inputEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // objectScore.AddScore();
            inputEvent.Invoke();
        }
    }
}