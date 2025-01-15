using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private int score = 0;

    private void OnEnable()
    {
        //TODO: Subscribe IncreaseScore to OnObjectDestroyedEvent
    }

    private void OnDisable()
    {
        
    }

    private void Start() => DisplayScore();

    private void IncreaseScore(int amount) => score += amount;

    private void DisplayScore() => scoreText.text = $"{score}";

    private void ResetScore() => score = 0;

    public int GetScore() => score;
}
