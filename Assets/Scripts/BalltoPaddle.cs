using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalltoPaddle : MonoBehaviour
{

    [SerializeField] PaddleMovement paddle;
    Vector2 paddleToBallVector;
    private bool isLaunched = false;
    public float Xspd = 3f;
    public float Yspd = 14f;
    [SerializeField] AudioClip[] ballsounds;
    AudioSource Audio;
        // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
        Audio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!isLaunched) { 
        LockToPaddle();
        LaunchBall();
    }
    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isLaunched = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(Xspd, Yspd);
        }
    }

    private void LockToPaddle()
    {
       
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tuning = new Vector2(Random.Range(0f, 3f), Random.Range(0f, 3f));
        if (isLaunched)
        {
            AudioClip clips = ballsounds[UnityEngine.Random.Range(0, ballsounds.Length)];
            Audio.PlayOneShot(clips);
        }
    }
}
