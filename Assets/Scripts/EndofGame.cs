using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndofGame : MonoBehaviour
{
    public AudioSource winingSound;
    public AudioSource losingSound;

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

        if(win)
        {
            gameController.EndGameText.text = "YOU WIN!";
            gameController.EndGameText.enabled = true;
            winingSound.Play();
        }
        else
        {
            gameController.EndGameText.text = "YOU LOSE";
            gameController.EndGameText.enabled = true;
            losingSound.Play();
        }
        
    }
}
