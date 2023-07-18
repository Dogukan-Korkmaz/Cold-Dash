using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SerializeField h�zl� bir �ekilde farkl� de�i�kenleri test etmek i�in kullan�l�r.
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;

    //Evrensel De�i�kenler
    Rigidbody2D rb2d;
    SurfaceEffector2D ground1speed, ground2speed;
    GameObject ground,ground2;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //De�er �ekme blo�u
        ground = GameObject.FindGameObjectWithTag("Ground");
        ground2 = GameObject.FindGameObjectWithTag("Ground2");
        ground1speed = ground.GetComponent<SurfaceEffector2D>();
        ground2speed = ground2.GetComponent<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        // Yukar� tu�uyla h�z� artt�r aksi halde normal h�zda kal
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ground1speed.speed = boostSpeed;
            ground2speed.speed = boostSpeed;
        }
        else
        {
            ground1speed.speed = baseSpeed;
            ground2speed.speed = baseSpeed;
        }
       
    }

    void RotatePlayer()
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
