using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public float time { get; private set; }
    public int score { get; private set; }
    public int combo { get; private set; }
    List<IEffect> effects;

    public float MAX_TIME = 40;
    public float MIN_TIME = 0;
    
    void Awake()
    {
        effects = new List<IEffect>();
        score = 0;
        combo = 0;
        time = MAX_TIME;
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
	}

    void UpdateTime()
    {
        
    }

}
