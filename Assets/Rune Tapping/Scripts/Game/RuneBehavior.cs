using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneBehavior : MonoBehaviour {

    public GameObject rune, groundExplosion, touchEffect;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Vertical") * Vector2.up * Time.deltaTime);
	}

    public void OnHitFloor()
    {
        rune.SetActive(false);
        groundExplosion.SetActive(true);
    }

    void OnFinishAnimation()
    {

    }
}
