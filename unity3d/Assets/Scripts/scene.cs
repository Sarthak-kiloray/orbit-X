using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public void earth()
    {
        SceneManager.LoadScene("earth");
    }
    public void solar()
    {
        SceneManager.LoadScene("solar");
    }
}
