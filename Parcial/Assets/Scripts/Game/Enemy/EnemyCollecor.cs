using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollecor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.SetActive(false);
        //Destroy(other.gameObject);
    }
}
