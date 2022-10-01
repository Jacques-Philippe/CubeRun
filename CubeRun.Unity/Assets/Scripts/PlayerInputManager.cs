using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    /// <summary>
    /// A reference to our game manager instance
    /// </summary>
    private GameManager gameManager;

    private void Start()
    {
        var manager = GameObject.FindObjectOfType<GameManager>();
        this.gameManager = manager;
    }


    private void Update()
    {
        if (gameManager.IsGameOver)
        {
            GameOverInputScheme();
        }
        else
        {
            GameInputScheme();
        }
    }

    #region INPUT SCHEMES

    private void GameOverInputScheme()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameManager.Reset();
        }
    }

    private void GameInputScheme()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
        }
    } 
    #endregion
}
