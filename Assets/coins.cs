using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    Text coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        coinAmount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinAmount.text = $"Coin : {movement.coin} / {movement.totalCoin}";
    }
}
