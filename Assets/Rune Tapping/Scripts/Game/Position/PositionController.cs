
using UnityEngine;

public class PositionController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime);
	}

}
