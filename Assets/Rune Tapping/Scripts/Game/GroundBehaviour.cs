using UnityEngine;

public class GroundBehaviour : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SendMessage("OnHitFloor");
    }

}
