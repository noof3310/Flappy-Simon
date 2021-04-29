using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isStart = false;
    public bool IsStart
    {
        get { return isStart; }
        set { isStart = value; }
    }
    private bool isPlaying = false;
    public bool IsPlaying
    {
        get { return isPlaying; }
        set { isPlaying = value; }
    }
    private int playerScore = 0;
    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private UIManager uiManager = default;
    private UIManager uiMangement
    {
        get
        {

            if (uiManager == null)
            {
                uiManager = FindObjectOfType<UIManager>();
            }
            return uiManager;
        }
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);
    }
    public void AddOnePoint()
    {
        playerScore++;

        uiMangement.SetScore(playerScore);
    }

    public void Pause()
    {
        isPlaying = false;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isPlaying = true;
        Time.timeScale = 1f;
    }

    public void ResetGame()
    {
        playerScore = 0;
        Resume();
        StartCoroutine(LoadSceneAsync("Game 1"));
    }

    public void StopGame()
    {
        Pause();
        uiMangement.ActiveResult();
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

