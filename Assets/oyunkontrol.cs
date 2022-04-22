using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour
{
    int maxsayi = 100;
    int minsayi = 1;
    int tahmin;
    bool oyunbasladi = false;
    bool oyunbitti = false;
    void Start()
    {
        print("Benimle Oyun Oynamak �ster misin?    (E/H)");
     
    }

   
    void Update()
    {
        if (!oyunbasladi)   //oyun ba�lamad�ysa
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Akl�ndan 1-100 aras� bir say� tut ve enter tu�una bas");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen bilirsin");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                kontrol();
                oyunbasladi = true;
            }
        }

        else if (!oyunbitti) // oyun bitmediyse 
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minsayi = tahmin;
                kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxsayi = tahmin;
                kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Harika.Akl�ndaki say�y� buldum");
                oyunbitti = true;
            }
        }
        void kontrol()
        {
            tahmin = (maxsayi + minsayi) / 2;
            print("Akl�ndan tuttu�un say� " + tahmin + "mi ? Daha b�y�k ise yukar� ,  daha k���k ise a�a�� y�n tu�una bas�n.Do�ru ise bo�luk tu�una bas�n");

        }
    }
}
