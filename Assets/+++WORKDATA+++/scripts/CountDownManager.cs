using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDownManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] float remainingTime;
    public GameObject player;
    public GameObject counterVisual;
    public GameObject timerVisual;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            player.SetActive(false);
            timerVisual.SetActive(false);
        }
        else
        {
            remainingTime = 0;
            player.SetActive(true);
            counterVisual.SetActive(false);
            timerVisual.SetActive(true);
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        counterText.text = string.Format("{0}",seconds);
    }
}
