using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    GameManager gameManager = default;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameManager)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
        gameManager.StopGame();
    }
}
