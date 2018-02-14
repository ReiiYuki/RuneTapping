using UnityEngine;

public class CloudBehaviour : MonoBehaviour {

    public Sprite[] cloudSprites;
    public bool isDirectionRight;

    float speed;

    const float MAXIMUM_BOUND_X = 5f;
    const float MINIMUM_SPEED = 1f;
    const float MAXIMUM_SPEED = 5f;

    // Use this for initialization
    void Start()
    {
        ResetCloud();
    }

    // Update is called once per frame
    void Update () {
        if (isOutBound())
        {
            ResetCloud();
        }else
        {
            Move();
        }
	}

    bool isOutBound()
    {
        if (isDirectionRight)
        {
            return transform.position.x >= MAXIMUM_BOUND_X;
        }else
        {
            return transform.position.x <= -1*MAXIMUM_BOUND_X;
        }
    }

    void ResetCloud()
    {
        int cloudSpriteIndex = Random.Range(0, cloudSprites.Length);
        GetComponent<SpriteRenderer>().sprite = cloudSprites[cloudSpriteIndex];
        speed = Random.Range(MINIMUM_SPEED, MAXIMUM_SPEED);
        float originPositionX = isDirectionRight ? -1 * MAXIMUM_BOUND_X : MAXIMUM_BOUND_X;
        transform.position = new Vector2(originPositionX, transform.position.y);
    }

    void Move()
    {
        Vector2 direction = isDirectionRight ? Vector2.right : Vector2.left;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
