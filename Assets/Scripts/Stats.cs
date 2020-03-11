using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public float health = 10f;
    public float damageOnHit = 1f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHit(){
        health = health - damageOnHit;

        if (health <= 0f){
            Die();
        }
    }

    private void Die(){
        Destroy(this.gameObject);
    }



}
