using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController1 : MonoBehaviour
{


        public float fireDelay = 1f;
        private float maxPositionX = 1;
        private float minPositionX = 0;
        private bool movingRight = true;
        public float movementSpeed = 1f;


    // Start is called before the first frame update
        void Start()
    {

        //Tamaño pantalla
        //Screen.Width
        //Tamaño de pantalla

    }

    // Update is called once per frame
    void Update()
    {


        maxPositionX = 1;
        minPositionX = 0;

        //Get viewport sizes to x and y
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);

        // transform.position = Camera.main.ViewportToWorldPoint(pos);


        if(movingRight){
            //Move right
            transform.Translate(new Vector2(movementSpeed, 0f));

            //Revisar si llga al limite en x permitido
            if(pos.x >= maxPositionX){
                movingRight = false;
            }
        } else {
            //Move Left
            transform.Translate(new Vector2(-movementSpeed, 0f));

            //Revisar si llga al limite en x permitido
            if(pos.x <= minPositionX){
                movingRight = true;
            }

        }
        

    }
}
