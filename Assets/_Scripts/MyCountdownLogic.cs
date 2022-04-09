using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*
 * class to display a countdown timer in the form:
 * "Countdown seconds remaining = 12"
 * 
 * when finished display message:
 * "countdown has finished"
 */
public class MyCountdownLogic : MonoBehaviour
{
	public int timerTotal = 10;

	// reference to UI Text object whose text we'll update with countdown message
	private Text textClock;

	// how many seconds to count down from
    private CountdownTimer countdownTimer;

	//---------------------------------
    void Start()
    {
	    // get reference to Text component inside our parent GameObject
	    textClock = GetComponent<Text>();

	    // get reference to CountdownTimer object
	    countdownTimer = GetComponent<CountdownTimer>();

	    // reset countdown timer to start from 30 seconds
        countdownTimer.ResetTimer(timerTotal);
    }

	//---------------------------------
	// do this EVERY frame .......
	void Update ()
	{
        // get seconds remaining (as a whole number)
        int timeRemaining = countdownTimer.GetSecondsRemaining();

        if (timeRemaining < 1){
	        // do something when timer ends!
	        TimerFinishedAction();
        }
        else
        {
	        // message based on seconds left
	        string message = "Time left = " + timeRemaining;

	        // update 'text' component of our UI Text object with string message
	        textClock.text = message;
        }
	}

	//---------------------------------
	private void TimerFinishedAction()
	{   
        // ------ action to do when timer ends goes here -----
        
        // for now new message on screen
        textClock.text = "TIME HAS RUN OUT!!!!!!!!";
        
        
        // goto game over scene or something  ....
//        int gameOverSceneNumber = 4;
//        SceneManager.LoadScene(gameOverSceneNumber);

	}
}
