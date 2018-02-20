
using UnityEngine;

class XRuneEffect : Effect
{
    protected float time = 0;
    public override void ApplyEffect(GameController game)
    {
        game.BreakCombo();
    }
}

public class XRuneController : RuneController
{
    protected override void ApplyEffect()
    {
        GameObject.FindObjectOfType<GameController>().AddEffect(new XRuneEffect());
    }

    protected override void OnFinishAnimation()
    {
        GameObject.FindObjectOfType<RuneGenerator>().AddToXRunePool(gameObject);
    }

}
