using UnityEngine;
using UnityEngine.UI;

public class ScoreVisualizer : MonoBehaviour {

    public GameObject gameController;
	
	// Update is called once per frame
	void Update () {
        UpdateScore();
	}

    void UpdateScore()
    {
        GetComponent<Text>().text = gameController.GetComponent<GameController>().score.ToString();
    }
}
