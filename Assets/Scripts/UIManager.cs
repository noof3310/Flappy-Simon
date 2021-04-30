using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText = default;
    [SerializeField]
    private Text highScoreText = default;
    [SerializeField]
    private GameObject result = default;

    public void ActiveResult()
    {
        result.SetActive(true);
    }

    public void SetScore(int value)
    {
        scoreText.text = value.ToString();
    }

    public void SetHighscore(int value)
    {
        highScoreText.text = value.ToString();
    }

    public void Replay()
    {
        GameManager.Instance.ResetGame();
    }

    private void Update()
    {
        if (!GameManager.Instance.IsPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Replay();
            }
        }
    }
}
