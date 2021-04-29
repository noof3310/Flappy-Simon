using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;

    void Update()
    {
        if (GameManager.Instance.IsPlaying)
        {
            if (timer > maxTime)
            {
                GameObject newPipe = Instantiate(pipe);
                newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newPipe, 15);
                timer = 0;
            }

            timer += Time.deltaTime;
        }
    }
}
