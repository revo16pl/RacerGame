using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndofGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var gameController = FindObjectOfType<GameController>();

            if (gameController.coinsCollected >= (gameController.coinsCount/gameController.difficulity))
            {
                EndGame(true, gameController);
            }
        }             
    }

    public void EndGame(bool win, GameController gameController)
    {
        gameController.EndGameText.text = win ? "YOU WIN!" : "YOU LOSE!";
        gameController.EndGameText.enabled = true;
    }
}
