using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    private long _currentScore = 0;

	private void IncrementScore()
    {
        GetComponent<Text>().text = "Score: " + _currentScore++;
    }

	// Update is called once per frame
	void Update () {
        IncrementScore();
    }
}
