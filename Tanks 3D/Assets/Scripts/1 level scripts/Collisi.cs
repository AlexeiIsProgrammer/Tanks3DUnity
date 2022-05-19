using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Threading;



public class Collisi : MonoBehaviour
{
    //public bool gameOver = false;
    public static void Copy()
    {
        print("слива2");
        NewBehaviourScript SourceObject = GameObject.Find("EmptyObj").GetComponent<NewBehaviourScript>();
        if (SourceObject == null) return;

        SourceObject.WriteInFile();
        print("слива3");
    }

    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("Wall"))
        {
            print("Стена!!!");
        }
        if(collision.gameObject.tag == "Tank1")
        {
            print("меня задели");

            if (collision.gameObject.GetComponent<Heal>().Damage(100))
            {
                GameObject.Find("ImRanen").GetComponent<AudioSource>().Play();
                BarOfHealth.AdjustCurrentValue(-100);
                print("-100");
            }
            else
            {
                GameObject.Find("Kill").GetComponent<AudioSource>().Play();
                Copy();
                SceneManager.LoadScene(14);
                print("слива1");
                //gameOver = true;
                
            }
        }
        if (collision.gameObject.name == "Platform")
        {
            
            print("Платформа задета!");
        }
        
        if (collision.gameObject.tag == "Enemy" && this.gameObject.tag!="bul")
        {
            print("Противник задет!!");
            if (collision.gameObject.GetComponent<Heal>().Damage(100))
            {
                GameObject.Find("DamageMusic").GetComponent<AudioSource>().Play();
                print("-100 противнику");
            }
            else
            {
                print("Убит");
                Destroy(collision.gameObject);
                NewBehaviourScript.tanksKills += 1;
                print(NewBehaviourScript.tanksKills);
                //gameOver = true;
                if (SceneManager.GetActiveScene().buildIndex == 1 && NewBehaviourScript.tanksKills == 3)
                {
                    Copy();
                    SceneManager.LoadScene(15);
                }
            }
        }

        if (collision.gameObject.tag == "Base" && this.gameObject.tag == "bul")
        {
            print("База задета!");

            if (collision.gameObject.GetComponent<Heal>().Damage(100))
            {
                print("-100");
            }
            else
            {
                print("You loose");
                //gameOver = true;
                Copy();
                SceneManager.LoadScene(14);
            }
        }
        Destroy(this.gameObject);
    }
   
   
}
