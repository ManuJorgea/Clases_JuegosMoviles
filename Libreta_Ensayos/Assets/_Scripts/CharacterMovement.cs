using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public float direction;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
    }
}
