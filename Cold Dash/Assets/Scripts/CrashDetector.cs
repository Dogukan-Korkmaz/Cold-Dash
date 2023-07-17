using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "ground")
    //    {
    //        Debug.Log("Ah.. Baþým!");
    //    }
        
    //}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log(other.gameObject.name);
        }
    }
}
