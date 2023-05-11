using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SerializeField h�zl� bir �ekilde farkl� de�i�kenleri test etmek i�in kullan�l�r.
    [SerializeField] float torqueAmount = 1f;


    //Evrensel De�i�kenler
    Rigidbody2D rb2d;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); //De�er �ekme blo�u
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))//klavyeden sol ok tu�una bas�ld���nda devreye girecek
        {
            rb2d.AddTorque(torqueAmount);//Tork kuvveti uygulayacak.
        }
        if (Input.GetKey(KeyCode.RightArrow))//klavyeden sa� ok tu�una bas�ld���nda devreye girecek
        {
            rb2d.AddTorque(-torqueAmount);//Tork kuvveti uygulayacak.Z�t kutuplara uygulans�n diye ba��na - koyuyorum.
        }
    }
}
