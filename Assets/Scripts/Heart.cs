using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class Heart : MonoBehaviour
    {
        private PlatformerCharacter2D player;
        
        void Start()
        {
            GameObject playerObject = GameObject.FindWithTag("Player");
            player = playerObject.GetComponent<PlatformerCharacter2D>();
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            
            if (other.tag == "Player")
            {
                player.AddHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
