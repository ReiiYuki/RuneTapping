﻿using System.Collections;
using System.Collections.Generic;
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
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
