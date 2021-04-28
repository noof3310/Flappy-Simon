using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField]
    AudioSource jump = default;

    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
            jump.Play();
        }

    }
}
