using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
        public float maxYPosition = 100;

        public float minYPosition = -100;

        public float projectileSpeed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, projectileSpeed));
        if(transform.position.y > maxYPosition || transform.position.y < minYPosition){
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D other){
                if(other.gameObject.tag == "Enemy"){
                Stats enemyStats = other.gameObject.GetComponent<Stats>();
                enemyStats.OnHit();
            }
    }
}
