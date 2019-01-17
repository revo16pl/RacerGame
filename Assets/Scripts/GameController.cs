using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text CoinCounterText;
    public Text CountDownText;
    public Text EndGameText;
    public GameObject Player;
    public float coinsCollected;
    public float coinsCount;
    public readonly float difficulity = 2;
    public bool win;

    void Start()
    {
        EndGameText.enabled = false;

        CoinsCollection();

        StartCoroutine(GameStartCountdown());
    }

    IEnumerator GameStartCountdown()
    {
        CountDownText.enabled = true;

        var Rigidbody = Player.GetComponent<Rigidbody>();
        Rigidbody.constraints = RigidbodyConstraints.FreezeAll;

        for (int i = 3; i > 0; i--)
        {
            CountDownText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        CountDownText.text = "Start!";
        yield return new WaitForSeconds(1f);

        CountDownText.enabled = false;

        Rigidbody.constraints = RigidbodyConstraints.None;
    }

    public void CoinsCollection()
    {
        coin[] coinsAll = FindObjectsOfType<coin>();

        coinsCount = coinsAll.Length;
        coinsCollected = coinsAll.Count(coin => !coin.isActive);

        CoinCounterText.text = coinsCollected + "/ " + coinsCount;

        CoinsCollectionTextColor();
    }

    private void CoinsCollectionTextColor()
    {
        if (coinsCollected == coinsCount)
        {
            Color gold = new Color(190, 190, 0);
            CoinCounterText.color = gold;
        }

        else if (coinsCollected >= (coinsCount / difficulity))
        {
            Color pink = new Color(255, 0, 205);
            CoinCounterText.color = pink;
        }
    }    
}
