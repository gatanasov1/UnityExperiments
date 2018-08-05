using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish: MonoBehaviour {

    [SerializeField]
    private float _upwardForceMultiplier = 300f;
    

    // Update is called once per frame
    void Update () {
        bool pressedFireButton = Input.GetButton("Fire1");

        if (pressedFireButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier * Time.deltaTime * 50);
        }

        if (transform.position.y > 6 || transform.position.y < -6)
        {
            SceneManager.LoadScene("GameStart", LoadSceneMode.Single);
        }
	}
}
