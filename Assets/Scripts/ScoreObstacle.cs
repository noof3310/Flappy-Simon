using UnityEngine;

public class ScoreObstacle : MonoBehaviour
{
    GameManager gameManager = default;
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.AddOnePoint();
    }
}
