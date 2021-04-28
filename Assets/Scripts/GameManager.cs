using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText = default;
    [SerializeField]
    private GameObject result = default;

    private int playerScore = 0;
    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }
    private void Awake()
    {
        result.SetActive(false);
    }
    public void AddOnePoint()
    {
        playerScore++;
        scoreText.SetText(playerScore.ToString());
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void ResetGame()
    {
        playerScore = 0;
        Resume();
        //TODO: change to "Game", if you complete connect the gameobject.
        StartCoroutine(LoadSceneAsync("Game 1"));
    }

    public void StopGame()
    {
        Pause();
        result.SetActive(true);
    }

    public static IEnumerator LoadSceneAsync(string name)
    {
        var async = SceneManager.LoadSceneAsync(name);

        while (!async.isDone)
        {
            yield return null;
        }
    }
}

