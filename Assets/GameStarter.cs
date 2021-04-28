using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private GameManager gameManager = default;
    private bool isPlay = false;
    [SerializeField] GameObject gameStart;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if ( !isPlay && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) )
        {
            isPlay = true;
            gameManager.Resume();
            gameStart.SetActive(false);
        }
    }
}
