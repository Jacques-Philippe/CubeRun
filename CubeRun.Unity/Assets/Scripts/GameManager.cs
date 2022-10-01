using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameOver = false;
    public bool IsGameOver { get => isGameOver; }

    private PlayerInputManager playerInputManager;
    private AudioManager audioManager;
    private ScoreManager scoreManager;
    private ObstacleManager obstacleManager;
    private UIManager uiManager;

    public void EndGame()
    {
        this.isGameOver = true;
    }

    public void Reset()
    {
        //Reload the active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
