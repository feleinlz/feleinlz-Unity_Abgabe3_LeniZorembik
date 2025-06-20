using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject winScreen;
    public GameObject player;
    public GameObject overlay;
    

    // Update is called once per frame
    void Update()
    {
       
        if (gameOverScreen.activeInHierarchy)
        {
            overlay.SetActive(false);
        }
        
       
        if (winScreen.activeInHierarchy)
        {
            player.SetActive(false);
            overlay.SetActive(false);
        }
    }
    
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit();
    }
    
}
