using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneBehaviour : MonoBehaviour {

    void OnMouseDown()
    {
        transform.parent.SendMessage("OnSelect");
    }
}
