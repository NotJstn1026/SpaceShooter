using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private int score = 0;

    private void OnEnable()
    {
        Enemy.OnDestroyed += IncreaseScore;
    }

    private void OnDisable()
    {
        Enemy.OnDestroyed -= IncreaseScore;
    }

    private void Start() => DisplayScore();

    private void IncreaseScore(int amount)
    {
        score += amount;
        DisplayScore();
    }

    private void DisplayScore() => scoreText.text = $"{score}";

    private void ResetScore() => score = 0;

    public int GetScore() => score;
}
