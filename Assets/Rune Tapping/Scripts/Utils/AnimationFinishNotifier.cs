
using UnityEngine;

public class AnimationFinishNotifier : MonoBehaviour {

    public bool isFinishAnimation;

	// Update is called once per frame
	void Update () {
	    if (isFinishAnimation)
        {
            FinishAnimation();
        }	
	}

    void FinishAnimation()
    {
        transform.parent.SendMessage("OnFinishAnimation");
        isFinishAnimation = false;
        gameObject.SetActive(false);
    }

}
