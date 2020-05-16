using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCollision:MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != gameObject.tag)
        {
            print("objeto distinto");
            GameController.instance.score += 10;
            other.gameObject.SetActive(false);
            
            //Destroy(other.gameObject);
        }
        else 
        {
            print("objeto igual");
            GameController.instance.vidas -= 1;
            other.gameObject.SetActive(false);
        }
    }
  
}
