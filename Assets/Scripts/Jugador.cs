using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 1;
    private void Update()
    {
        //variables y sus movimientos
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yMove = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //el objeto se tralada en x & en y
        transform.Translate(new Vector2(xMove, yMove)); 
    }
}
