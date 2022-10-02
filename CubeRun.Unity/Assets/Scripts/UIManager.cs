using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// Score received from Score manager, to be transmitted to ScoreReceiver
    /// </summary>
    [HideInInspector]
    public string Score;

    [SerializeField]
    private GameObject GameUI;

    [SerializeField]
    private GameObject GameOverUI;

    private GameManager gameManager;
    private ScoreReceiver scoreReceiver;

    // Start is called before the first frame update
    void Start()
    {
        this.gameManager = GameObject.FindObjectOfType<GameManager>();
        this.scoreReceiver = GameObject.FindObjectOfType<ScoreReceiver>();

        StartCoroutine("DisplayUI");
    }

    private IEnumerator DisplayUI()
    {
        yield return new WaitUntil(() => {
            DisplayGameUI();
            return gameManager.IsGameOver;
        });
        RemoveGameUI();
        DisplayGameOverUI();
    }

    private void DisplayGameUI()
    {
        Debug.Log($"Displaying game UI with score {Score}");
        this.scoreReceiver.Score = this.Score;
    }

    private void RemoveGameUI()
    {

    }

    private void DisplayGameOverUI()
    {
        Debug.Log($"Displaying game over UI with score {Score}");
    }

}
