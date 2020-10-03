using UnityEngine;
using System.Collections;

public class lookat : MonoBehaviour
{

    static public GameObject target; 

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("LookAtTarget target not specified. Defaulting to parent GameObject 333");
        }
    }
    
    void Update()
    {
        if (target)
            transform.LookAt(target.transform);
    }
}
