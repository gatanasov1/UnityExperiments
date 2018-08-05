using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour {

    [SerializeField]
    private float _scrollRate = 5f;
	
	// Update is called once per frame
	void Update () {
        Vector2 currentTextureOffset = this.GetComponent<Renderer>().material.mainTextureOffset;

        float distanceToScrollLeft = _scrollRate * Time.deltaTime;

        Vector2 newTextureOffset = new Vector2(currentTextureOffset.x + distanceToScrollLeft, currentTextureOffset.y);

        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", newTextureOffset);
	}
}
