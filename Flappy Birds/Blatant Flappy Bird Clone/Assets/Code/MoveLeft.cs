using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    [SerializeField]
    private float _moveFactor = 1f;

    [SerializeField]
    private bool _randomizeHeight = true;


    // Update is called once per frame
    void Update () {
        transform.Translate((Vector3.left * _moveFactor) * Time.deltaTime);

        if (transform.position.x <= -15f)
        {
            float yPosition = _randomizeHeight? UnityEngine.Random.Range(-3, 3): transform.position.y;
            transform.position = new Vector3(15, yPosition, 0);
        }
	}
}
