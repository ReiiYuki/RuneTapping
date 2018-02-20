
using UnityEngine;

public abstract class RuneController : MonoBehaviour {

    public GameObject rune, groundExplosion, touchEffect;

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

    public void ResetRune()
    {
        rune.SetActive(true);
        groundExplosion.SetActive(false);
        touchEffect.SetActive(false);
    }

}
