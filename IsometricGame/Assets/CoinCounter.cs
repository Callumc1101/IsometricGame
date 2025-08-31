using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int coinCounter = 0;
    public TMP_Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        coinCounter += 1;
        counterText.text = "COINS: " + coinCounter;
    }
}
