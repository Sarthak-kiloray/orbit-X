using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class navstar1 : MonoBehaviour
{
    public GameObject Panel;
    void OnMouseDown()
    {

        Debug.Log("Magellon wala button");
        Panel.gameObject.SetActive(true);
    }
}