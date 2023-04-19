using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDestroy : MonoBehaviour
{
    public AudioClip destroySound; // optional sound to play when destroyed
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // replace "Enemy" with the tag of the object you want to collide with
        {
            if (destroySound != null)
            {
                AudioSource.PlayClipAtPoint(destroySound, transform.position);
            }
            Destroy(gameObject);
        }
    }
}
