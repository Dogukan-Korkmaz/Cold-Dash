using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Invoke("ReloadScene", loadDelay); 
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
