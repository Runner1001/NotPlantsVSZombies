using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
