using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DiamondManager : MonoBehaviour
{
    public int diamondCount;
    public TMP_Text diamondText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diamondText.text = "Flames: " + diamondCount.ToString();
    }
}
