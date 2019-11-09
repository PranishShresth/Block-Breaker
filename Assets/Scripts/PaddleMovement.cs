using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float MinX = 1f;
    public float MaxX = 14f;
 
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Mathf.Clamp(_mousePos.x,MinX,MaxX),transform.position.y, transform.position.z);
    }
}
