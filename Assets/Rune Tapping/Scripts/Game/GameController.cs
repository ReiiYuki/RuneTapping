using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int score { get; private set; }
    public int combo { get; private set; }
    public int scoreEffect { get; private set; }
    public float time { get; private set; }
    public float timeEffect { get; private set; }

    List<Effect> effects;

    public float MAX_TIME = 40;
    public float MIN_TIME = 0;
    
    void Awake()
    {
        InitGame();
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        ResetEffect();
        ApplyEffects();
        UpdateTime();
	}

    void UpdateTime()
    {
        time -= timeEffect*Time.deltaTime;
    }
    
    public void AddEffect(Effect effect)
    {
        effects.Add(effect);
    }

    void ApplyEffects()
    {
        List<Effect> timeOutEffects = new List<Effect>();
        foreach (Effect effect in effects){
            effect.ApplyEffect(this);
            effect.UpdateLife(Time.deltaTime);
            if (effect.IsEnd()) timeOutEffects.Add(effect);
        }
        ClearTimeOutEffects(timeOutEffects);
    }

    void ClearTimeOutEffects(List<Effect> timeOutEffects)
    {
        foreach (Effect timeOutEffect in timeOutEffects) effects.Remove(timeOutEffect);
    }

    void ResetEffect()
    {
        timeEffect = 1;
        scoreEffect = 1;
    }

    public void UpdateScore()
    {
        score += (score + combo * 100) * scoreEffect;
    }

    public void UpdateCombo()
    {
        combo++;
    }

    public void BreakCombo()
    {
        combo = 0;
    }

    void InitGame()
    {
        effects = new List<Effect>();
        score = 0;
        combo = 0;
        time = MAX_TIME;
    }

}
