using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "spawn")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }
}
