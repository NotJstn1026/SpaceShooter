using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{
    [SerializeField] Button startButton;
    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
