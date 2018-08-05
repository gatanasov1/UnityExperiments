using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("GameStart", LoadSceneMode.Single);
    }
}
