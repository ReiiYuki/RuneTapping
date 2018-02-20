
public abstract class Effect {

    protected float lifeTime;

    public abstract void ApplyEffect(GameController game);

    public void UpdateLife(float time)
    {
        lifeTime -= time;
    }

    public bool IsEnd()
    {
        return lifeTime <= 0;
    }

}
