using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class Test_Mob_follow : MonoBehaviour
    {
        
        private Rigidbody2D rb;
        GameObject player;
        Transform playerTransform;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Entity movement
        void Update()
        {
            GameObject player = GameObject.FindWithTag("Player");
            Transform playerTransform = player.transform;
            // get player position
            Vector3 position = playerTransform.position;

            //move closer to senpai, I mean the player
            if (playerTransform.position.x > rb.position.x)
            {
                rb.AddForce(new Vector2(100, 0));
            }
            if (playerTransform.position.x < rb.position.x)
            {
                rb.AddForce(new Vector2(-100, 0));
            }
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
                    Destroy(gameObject);
                    
                }
            }
        }
    }
}
