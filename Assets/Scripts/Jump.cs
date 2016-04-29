using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class Jump : MonoBehaviour
    {

        private float modifier = 1.5f;
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
                player.UpdateJump(modifier);
                Destroy(gameObject);
            }
        }
    }
}
