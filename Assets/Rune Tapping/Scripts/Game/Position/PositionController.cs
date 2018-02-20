
using UnityEngine;

public class PositionController : MonoBehaviour {

    public GameObject gameController;

	// Update is called once per frame
	void Update () {
        UpdatePosition();
	}

    void UpdatePosition()
    {
        GameController controller = gameController.GetComponent<GameController>();
        transform.Translate(Vector3.up * Time.deltaTime * controller.timeEffect);
    }

}
