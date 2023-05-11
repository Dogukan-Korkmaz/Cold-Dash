using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SerializeField hýzlý bir þekilde farklý deðiþkenleri test etmek için kullanýlýr.
    [SerializeField] float torqueAmount = 1f;


    //Evrensel Deðiþkenler
    Rigidbody2D rb2d;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); //Deðer çekme bloðu
    }

    void Update()
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
