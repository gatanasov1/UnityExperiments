using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour {

    [SerializeField]
    private float _climbRate = 3f;

    private void Reset()
    {
        this.transform.position = new Vector3(7, -4, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Fish>() != null)
        {
            GameObject.FindObjectOfType<ScoreKeeper>().IncrementScore(100);
            Reset();
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _climbRate);
        if (transform.position.y > 10)
        {
            Reset();
        }
    }

}
