
using UnityEngine;

class ScoreRuneEffect : NormalRuneEffect
{
    protected float time = 10;
    public override void ApplyEffect(GameController game)
    {
        game.ApplyScoreEffect();
        Debug.Log("In");
        base.ApplyEffect(game);
    }
}

public class ScoreRuneController : RuneController
{
    protected override void ApplyEffect()
    {
        GameObject.FindObjectOfType<GameController>().AddEffect(new ScoreRuneEffect());
    }

    protected override void OnFinishAnimation()
    {
        GameObject.FindObjectOfType<RuneGenerator>().AddToOtherRunePool(gameObject);
    }

    protected new void OnHitFloor()
    {
        base.OnHitFloor();
        GameObject.FindObjectOfType<GameController>().BreakCombo();
    }

}
