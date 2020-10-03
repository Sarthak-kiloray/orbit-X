using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class viewearth : MonoBehaviour
{

    public GameObject target; // the target that the camera should look at

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parentBLA BLA BLA");
        }
    }

    void onClick()
    {
        Application.LoadLevel("solar");
        //Camera.main.fieldOfView = 60 * target.transform.localScale.x;
        //Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 200);
        //Debug.Log("CHECCCCCCCCCCCCCKLA BLA BLA");
    }
}
