using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Collider2D collider;
    public GameManager manager;

    void Start()
    {
        collider = transform.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colision con " + collision.name);
        if(collision.transform.gameObject.tag == "Player")
        {
            manager.AddScore();
            gameObject.SetActive(false);
        }
    }
}
