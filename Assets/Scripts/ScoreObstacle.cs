using UnityEngine;

public class ScoreObstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.AddOnePoint();
    }
}
