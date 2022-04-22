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
        print("Benimle Oyun Oynamak Ýster misin?    (E/H)");
     
    }

   
    void Update()
    {
        if (!oyunbasladi)   //oyun baþlamadýysa
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Aklýndan 1-100 arasý bir sayý tut ve enter tuþuna bas");
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
                print("Harika.Aklýndaki sayýyý buldum");
                oyunbitti = true;
            }
        }
        void kontrol()
        {
            tahmin = (maxsayi + minsayi) / 2;
            print("Aklýndan tuttuðun sayý " + tahmin + "mi ? Daha büyük ise yukarý ,  daha küçük ise aþaðý yön tuþuna basýn.Doðru ise boþluk tuþuna basýn");

        }
    }
}
