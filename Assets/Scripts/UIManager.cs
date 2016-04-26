using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    //Holds Paused screen Objects 
    public GameObject pausedScreen;
    private GameObject currentPause;
    private bool isPaused = false;

    //Holds Collectables Objects
    private bool showCollectables = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown("escape"))
        {
            TogglePause();
        }
	}

    //Exits the game
    public void QuitGame()
    {
        Application.Quit();
    }

    //Starts the game
    public void StartGame()
    {
        Application.LoadLevel(0);
    }

    // Swaps the paused bool
    public void TogglePause()
    {
        if(isPaused == true)
        {
            isPaused = false;
            Time.timeScale = 1;

            //Hide UI
            Destroy(currentPause.gameObject);
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0;

            //Show UI
            currentPause = Instantiate(pausedScreen) as GameObject;
        }

    }
}
