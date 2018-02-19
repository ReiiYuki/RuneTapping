using UnityEngine;
using UnityEngine.UI;

public class ComboVisualizer : MonoBehaviour {

    public GameObject gameController;
    
	// Update is called once per frame
	void Update () {
        UpdateCombo();
	}

    void UpdateCombo()
    {
        GetComponent<Text>().text = "X"+gameController.GetComponent<GameController>().combo;
    }

}
