using System;
using UnityEngine;

public class PendeteksiInput : MonoBehaviour
{
    // public Score objectScore;

    public Action<int> inputEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // objectScore.AddScore();
            inputEvent.Invoke(5);
        }
    }
}
