using UnityEngine;

public class SkyGenerator : MonoBehaviour {

    public GameObject cloud;

    const float MINIMUM_CLOUD_HIGH = -3f;
    const float CLOUD_LAYER_DEPTH = 1f;
    const float DISTANCE_BETWEEN_LAYER = 3f;
    const float MINIMUM_CLOUD_BOUND_X = -5f;
    const int NUM_CLOUD_LAYER = 3;
    const int NUM_DIRECTION = 2;

	// Use this for initialization
	void Start () {
        GenerateSky();
	}
	
	void GenerateSky()
    {
        for (int i = 0; i < NUM_CLOUD_LAYER; i++)
        {
            float minY = MINIMUM_CLOUD_HIGH + i * DISTANCE_BETWEEN_LAYER;
            float maxY = minY + CLOUD_LAYER_DEPTH;
            float y = Random.Range(minY, maxY);
            bool isDirectionRight = Random.Range(0, NUM_DIRECTION) == 0;
            float x = isDirectionRight ? MINIMUM_CLOUD_BOUND_X : -1 * MINIMUM_CLOUD_BOUND_X;
            GameObject cloudObject = Instantiate(cloud, new Vector2(x, y), Quaternion.identity, transform);
            cloudObject.GetComponent<CloudBehaviour>().isDirectionRight = isDirectionRight;
        }
    }
}
