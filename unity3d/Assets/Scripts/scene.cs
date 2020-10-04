using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scene : MonoBehaviour
{    
    public void earthv()
    {
        SceneManager.LoadScene("earth");
    }
    public void solar()
    {
        SceneManager.LoadScene("solar");
    }
}
