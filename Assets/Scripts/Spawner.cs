using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public bool isBg = default;
    public float maxTime = 1.5f;
    private float timer = 0;
    public GameObject[] gameObjects;
    public float height = 1;

    void Update()
    {
        if (isBg || GameManager.Instance.IsPlaying)
        {
            if (timer <= 0)
            {
                GameObject gameObject = gameObjects[Random.Range(0, gameObjects.Length)];
                GameObject newObj = Instantiate(gameObject);
                newObj.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newObj, 15);
                timer = maxTime;
            }

            timer -= Time.deltaTime;
        }
    }
}
