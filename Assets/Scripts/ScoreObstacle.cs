using UnityEngine;

public class ScoreObstacle : MonoBehaviour
{
    GameManager gameManager = default;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gameManager)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
        gameManager.AddOnePoint();
    }
}
