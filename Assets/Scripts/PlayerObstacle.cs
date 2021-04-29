using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    GameManager gameManager = default;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.StopGame();
    }
}
