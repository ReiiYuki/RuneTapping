
using UnityEngine;

public abstract class RuneController : MonoBehaviour {

    public GameObject rune, groundExplosion, touchEffect;

	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Vertical") * Vector2.up * Time.deltaTime);
	}

    void OnHitFloor()
    {
        rune.SetActive(false);
        groundExplosion.SetActive(true);
    }

    protected abstract void OnFinishAnimation();

    protected abstract void ApplyEffect();

    void OnSelect()
    {
        rune.SetActive(false);
        touchEffect.SetActive(true);
        ApplyEffect();
    }
}
