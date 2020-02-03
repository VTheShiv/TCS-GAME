using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EvenCounter.Instance.totalNumber++;
            Debug.Log(EvenCounter.Instance.totalNumber);
            gameObject.SetActive(false);
        }

      
    }
}
