using UnityEngine;

public class ScoreUnity : MonoBehaviour
{
    public PendeteksiInputUnity pendeteksiInputUnity;

    public int score;

    public void AddScore()
    {
        score++;
    }

    void OnEnable()
    {
        pendeteksiInputUnity.inputEvent.AddListener(AddScore);
    }

    void OnDisable()
    {
        pendeteksiInputUnity.inputEvent.RemoveListener(AddScore);
    }
}
