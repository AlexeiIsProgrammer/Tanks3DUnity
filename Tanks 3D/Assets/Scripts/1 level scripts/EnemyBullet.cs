using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private bool del = true;

    public GameObject bulletF;
    public float speedBullet = 100f;

    public AudioSource expMusik;
    // Update is called once per frame
    void Shoot()
    {
        expMusik.Stop();
        expMusik.Play();
        GameObject newBullet = Instantiate(bulletF, transform.position, transform.rotation);
        newBullet.SetActive(true);
        newBullet.GetComponent<Rigidbody>().velocity = (transform.forward) * speedBullet;
    }
    private void changeBool()
    {
        del = true;
    }
    void FixedUpdate()
    {
        if(del)
        {
            Shoot();
            del = false;
            Invoke("changeBool", 3);

        }
        
    }
}
