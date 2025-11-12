using UnityEngine;

public class Score : MonoBehaviour
{
    public PendeteksiInput pendeteksiInput;

    public int score;

    public void AddScore(int nilai)
    {
        score += nilai;
    }

    void OnEnable()
    {
        pendeteksiInput.inputEvent += AddScore;
    }

    void OnDisable()
    {
        pendeteksiInput.inputEvent -= AddScore;
        
    }

}
