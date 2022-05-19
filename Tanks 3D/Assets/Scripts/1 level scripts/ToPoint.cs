using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
public class ToPoint : MonoBehaviour
{
    public GameObject BulletCreator;
    public GameObject House;
    private NavMeshAgent agent;
    public GameObject MyTank;

    bool check = true;

    public float speed = 20f;
    public float rSpeed = 1.0f;

    public AudioSource moveMusik;
    // Start is called before the first frame update
    void Start()
    {
        moveMusik.Play();
        BulletCreator.GetComponent<EnemyBullet>().enabled = false;
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = 5f;
    }

    // Update is called once per frame
    void GoodRotate(Transform other)
    {
        Vector3 targetDirection = other.transform.position - transform.position;
        float singleStep = rSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
        //Vector3 direction = other.position - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(direction);
        //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
    void FixedUpdate()
    {
        if (Vector3.Distance(MyTank.transform.position, transform.position) < 10f && check)
        {
            //print("Танк");
            agent.destination = MyTank.transform.position;
            BulletCreator.GetComponent<EnemyBullet>().enabled = true;
            GoodRotate(MyTank.transform);
            
        }
        else
        {
            if (Vector3.Distance(House.transform.position, this.transform.position) <= agent.stoppingDistance+4f)
            {
                print("Приехали!");
                BulletCreator.GetComponent<EnemyBullet>().enabled = true;
                GoodRotate(House.transform);
                moveMusik.mute = true;
                //Сделать его нефизическим объектом, чтобы нельзя было сдвинуть
                check = false;
            }
            else
            {
                BulletCreator.GetComponent<EnemyBullet>().enabled = false;
                agent.destination = House.transform.position;
            }
           // GoodRotate(House.transform);

        }

    }
}
