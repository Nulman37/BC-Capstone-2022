using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elescript : MonoBehaviour
{
    // Start is called before the first frame update
public float up = 100f;
public float range = 3f;
public GameObject elevator;
public bool isRising = false;
public Camera fpsCam;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveElevator(){
     isRising = true;
     elevator.GetComponent<Animator>().Play("ElLift");
     yield return new WaitForSecondsRealtime(5);
     Debug.Log ($"Time wait is {Time.time}");
    }

        /*
    public float health = 1f;
    public void TakeDamage (float amount){

        health -= amount;
        if (health <= 0f){
            Die();

        }
    }

    void Die(){
        Destroy(gameObject);

    }
    */
}