
using UnityEngine;

public class IceRuneController : RuneController
{

    bool isMelt, isFinish;
    public Sprite iceSprite, normalSprite;

    protected override void ApplyEffect()
    {
        if (isMelt)
        {
            GameObject.FindObjectOfType<GameController>().AddEffect(new NormalRuneEffect());
            isFinish = true;
        }
        else
        {
            isMelt = true;
            rune.SetActive(true);
            rune.GetComponent<SpriteRenderer>().sprite = normalSprite;
        }
    }

    protected override void OnFinishAnimation()
    {
        if (isFinish) GameObject.FindObjectOfType<RuneGenerator>().AddToOtherRunePool(gameObject);
    }

    protected new void OnHitFloor()
    {
        base.OnHitFloor();
        GameObject.FindObjectOfType<GameController>().BreakCombo();
    }

    public new void ResetRune()
    {
        base.ResetRune();
        rune.GetComponent<SpriteRenderer>().sprite = iceSprite;
    }

}
