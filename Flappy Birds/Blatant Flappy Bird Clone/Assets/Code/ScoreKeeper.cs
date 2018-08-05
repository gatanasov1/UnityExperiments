using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    private long _currentScore = 0;

	public void IncrementScore(int amount)
    {
        _currentScore += amount;
        GetComponent<Text>().text = "Score: " + _currentScore;
    }

	// Update is called once per frame
	void Update () {
        IncrementScore(1);
    }
}
