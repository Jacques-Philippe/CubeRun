using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public string Score;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        this.gameManager = GameObject.FindObjectOfType<GameManager>();

        StartCoroutine("DisplayUI");
    }

    private IEnumerator DisplayUI()
    {
        DisplayGameUI();
        yield return new WaitUntil(() => gameManager.IsGameOver);
        DisplayGameOverUI();
    }

    private void DisplayGameUI()
    {
        Debug.Log($"Displaying game UI with score {Score}");
    }

    private void DisplayGameOverUI()
    {
        Debug.Log($"Displaying game over UI with score {Score}");
    }
}
