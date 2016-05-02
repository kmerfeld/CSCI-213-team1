using UnityEngine;
using System.Collections;
using System;

namespace UnityStandardAssets._2D
{
    public class move : MonoBehaviour
    {
        
        private Rigidbody2D rb;
        GameObject player;
        Transform playerTransform;
        float originalY;
        public float floatStrength = 1;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Entity movement
        void Update()
        {
            transform.position = new Vector3(transform.position.x, originalY + ((float)Math.Sin(Time.time) * floatStrength), transform.position.z);

        }


        //check if player hits
        void OnCollisionEnter2D(Collision2D coll)
        {
            //these two lines can probably not be here, but i was getting 
            //null pointer without them
            GameObject player = GameObject.FindWithTag("Player");
            Transform playerTransform = player.transform;
            PlatformerCharacter2D platformchar = player.GetComponent<PlatformerCharacter2D>();

            //if its player
            if (coll.gameObject.tag == "Player")
            {

                //if the player is above
                if (playerTransform.position.y > rb.position.y + .9)
                {

                    Destroy(gameObject);

                }
                else {
                    platformchar.AddHealth(-1);
                    
                }
            }
        }
    }
}
