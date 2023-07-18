using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SerializeField hýzlý bir þekilde farklý deðiþkenleri test etmek için kullanýlýr.
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;

    //Evrensel Deðiþkenler
    Rigidbody2D rb2d;
    SurfaceEffector2D ground1speed, ground2speed;
    GameObject ground,ground2;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //Deðer çekme bloðu
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
        // Yukarý tuþuyla hýzý arttýr aksi halde normal hýzda kal
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
        if (Input.GetKey(KeyCode.LeftArrow))//klavyeden sol ok tuþuna basýldýðýnda devreye girecek
        {
            rb2d.AddTorque(torqueAmount);//Tork kuvveti uygulayacak.
        }
        if (Input.GetKey(KeyCode.RightArrow))//klavyeden sað ok tuþuna basýldýðýnda devreye girecek
        {
            rb2d.AddTorque(-torqueAmount);//Tork kuvveti uygulayacak.Zýt kutuplara uygulansýn diye baþýna - koyuyorum.
        }
    }
}
