using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
}
