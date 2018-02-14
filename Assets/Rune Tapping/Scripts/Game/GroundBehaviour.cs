using UnityEngine;

public class GroundBehaviour : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent.SendMessage("OnHitFloor");
    }

}
