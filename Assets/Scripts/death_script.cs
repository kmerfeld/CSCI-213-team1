using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class death_script : MonoBehaviour
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
            GameObject player = GameObject.FindWithTag("Player");
            Transform playerTransform = player.transform;
            // get player position
            Vector3 position = playerTransform.position;
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
                platformchar.AddHealth(-1);
            }
        }
    }
}