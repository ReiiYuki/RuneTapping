using UnityEngine;

public class TimeVisualizer : MonoBehaviour {

    public GameObject gameController;
	
	// Update is called once per frame
	void Update () {
        UpdateTime();
	}

    void UpdateTime()
    {
        GameController controller = gameController.GetComponent<GameController>();
        GetComponent<RectTransform>().localScale = new Vector3(controller.time/controller.MAX_TIME, 1, 1);
    }
}
