using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneController : MonoBehaviour {

    public GameObject rune, groundExplosion, touchEffect;
    protected int score = 1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Vertical") * Vector2.up * Time.deltaTime);
	}

    void OnHitFloor()
    {
        rune.SetActive(false);
        groundExplosion.SetActive(true);
    }

    void OnFinishAnimation()
    {

    }
    
    void OnSelect()
    {
        rune.SetActive(false);
        touchEffect.SetActive(true);
    }
}
