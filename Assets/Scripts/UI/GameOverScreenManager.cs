using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameOverScreenManager : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private Button goToMenuButton;
    [SerializeField] private TextMeshProUGUI finalScoreText;

    [SerializeField] private GameObject gameOverScreen;

    private ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Start()
    {
        gameOverScreen.SetActive(false); //Safety
    }

    private void OnEnable()
    {
        PlayerStatsHandler.OnDie += OpenGameOverScreen;

        restartButton.onClick.AddListener(RestartScene);
        goToMenuButton.onClick.AddListener(GoBackToMenuScene);
    }

    private void OnDisable()
    {
        PlayerStatsHandler.OnDie -= OpenGameOverScreen;

        restartButton.onClick.RemoveListener(RestartScene);
        goToMenuButton.onClick.RemoveListener(GoBackToMenuScene);
    }

    private void OpenGameOverScreen() //Gets called on OnDie-Event
    {
        Time.timeScale = 0;

        SetFinalScoreText();

        gameOverScreen.SetActive(true);
    }

    private void SetFinalScoreText()
    {
        finalScoreText.text = $"Final Score:\n{scoreManager.GetScore()}";
    }

    private void GoBackToMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    private void RestartScene()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
