using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject singleton = new GameObject();
                instance = singleton.AddComponent<GameManager>();
                singleton.name = instance.GetType().Name;
            }

            return instance;
        }

        private set { instance = value; }
    }

    private int playerScore = 0;
    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }

    public void AddOnePoint()
    {
        playerScore++;
        scoreText.SetText(playerScore.ToString());
        Debug.Log(playerScore);
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);
    }

    public static bool HasInstance { get { return instance != null; } }

    public void Destroy()
    {
        instance = null;
        Destroy(gameObject);
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
        Debug.Log("Reset");
        StartCoroutine(LoadSceneAsync("Game"));
    }

    public void StopGame()
    {
        Debug.Log("Stop");
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

