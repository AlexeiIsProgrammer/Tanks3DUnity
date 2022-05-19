using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{ 
    public GameObject bulletF;
    
    public float speed = 10f;
    private bool del = true;

    public AudioSource expMusik;

    void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.Space))
        {
            if (del)
            {
                expMusik.Stop();
                expMusik.Play();
                GameObject newBullet = Instantiate(bulletF, transform.position, transform.rotation);
                newBullet.SetActive(true);

                //newBullet.transform.position += Vector3.forward * Time.deltaTime;
                //newBullet.transform.position = newBullet.transform.forward * 3;   
                newBullet.GetComponent<Rigidbody>().velocity = speed * -(transform.forward);
                del = false;
                Invoke("changeBool", 1);
            }
                        
        }
    }
   
    private void changeBool()
    {
        del = true;
    }

   
}
