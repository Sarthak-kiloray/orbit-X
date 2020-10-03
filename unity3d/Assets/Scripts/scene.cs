using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scene : MonoBehaviour
{
    
    public void earth()
    {
        //CanvasGroup texnavstar1 = Canvas.GetComponent<CanvasGroup>();
        //textnavstar1.gameObject.SetActive(false);
        SceneManager.LoadScene("earth");
        

    }
    public void solar()
    {
        SceneManager.LoadScene("solar");
    }
}
