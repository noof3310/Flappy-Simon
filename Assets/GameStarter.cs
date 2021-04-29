using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField]
    GameObject gameStart = default;

    void Update()
    {
        if (!GameManager.Instance.IsStart)
        {
            if (!gameStart.activeSelf)
            {
                gameStart.SetActive(true);
            }

            if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
            {
                gameStart.SetActive(false);
                GameManager.Instance.Resume();
                GameManager.Instance.IsStart = true;
                GameManager.Instance.IsPlaying = true;
            }
        }

    }
}
