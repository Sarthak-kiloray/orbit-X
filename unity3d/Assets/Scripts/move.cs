﻿using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using System.Linq;
using System;


public class move : MonoBehaviour
{

    public GameObject target; // the target that the camera should look at
    public GameObject Panel;


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

        //Debug.Log("Magellon wala button");
        Panel.gameObject.SetActive(true);

        lookat.target = target;
        Camera.main.fieldOfView = 60 * target.transform.localScale.x;

    }
}
