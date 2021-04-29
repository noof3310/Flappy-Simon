using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText = default;
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

    public void Replay()
    {
        GameManager.Instance.ResetGame();
    }
}
