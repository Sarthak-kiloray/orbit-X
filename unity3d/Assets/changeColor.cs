using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Black()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
