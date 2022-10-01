using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    /// <summary>
    /// A reference to our game manager instance
    /// </summary>
    private GameManager gameManager;

    private PlayerMovement playerMovement;

    private void Start()
    {
        this.gameManager = GameObject.FindObjectOfType<GameManager>();
        this.playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
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
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A");
            this.playerMovement.MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D");
            this.playerMovement.MoveRight();
        }
    } 
    #endregion
}
