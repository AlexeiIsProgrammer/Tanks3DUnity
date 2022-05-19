using UnityEngine;
using System.Collections;

public class MoveTank : MonoBehaviour
{
    public float speed = 5f;
    public float rotSpeed = 20f;
    //public AudioClip clip;
    public AudioSource moveMusik;
    

    private void Start()
    {
        TakeTank = GetComponent<Rigidbody>();
        moveMusik.Play();
        //TTranslate.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            moveMusik.mute = false;
            MoveBack();
            
        } else
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            moveMusik.mute = false;
            MoveForward();
          
        }
        else
            moveMusik.mute = true;

        Rotate();
    }

    Rigidbody TakeTank;

    private void MoveForward()
    {
        Vector3 _position = transform.forward * speed * Time.deltaTime;
        Vector3 _pos = TakeTank.position - _position;

        TakeTank.MovePosition(_pos);
    }

    private void MoveBack()
    {
        Vector3 _position = transform.forward * speed * Time.deltaTime;
        Vector3 _pos = TakeTank.position + _position;

        TakeTank.MovePosition(_pos);
        
    }
    private void Rotate()
    {
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        Quaternion RotAngle = Quaternion.Euler(0,rot,0);

        Quaternion CurrentAngle = RotAngle * TakeTank.rotation;


        TakeTank.MoveRotation(CurrentAngle);
    }
  
    

}