
using UnityEngine;

class NormalRuneEffect : Effect
{
    protected float time = 0;
    public override void ApplyEffect(GameController game)
    {
        game.UpdateCombo();
        game.UpdateScore();
    }
}

public class NormalRuneController : RuneController {
    protected override void ApplyEffect()
    {
        GameObject.FindObjectOfType<GameController>().AddEffect(new NormalRuneEffect());
    }

    protected override void OnFinishAnimation()
    {
        GameObject.FindObjectOfType<RuneGenerator>().AddToNormalRunePool(gameObject);
    }

}
