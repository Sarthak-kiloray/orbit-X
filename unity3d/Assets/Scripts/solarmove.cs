using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using System.Linq;
using System;


public class solarmove : MonoBehaviour
{

    public GameObject target; 

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parent GameObject 1111");
        }
    }


    void OnMouseDown()
    {
        

        lookat.target = target;
        Camera.main.fieldOfView = 60 * target.transform.localScale.x;

    }
}
