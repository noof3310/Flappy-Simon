using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.ResetGame();
    }
}
