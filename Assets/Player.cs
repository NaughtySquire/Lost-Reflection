using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    float PSpeed = 0.05f;
    private Vector3 dir;
    [SerializeField]
    GameObject snake;

    // Start is called before the first frame update
    void Start()
    {
        SwipeHandler.SwipeEvent += OnSwipe;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            transform.Translate(dir.x * PSpeed, dir.y * PSpeed, 0);
            if (dir == Vector3.up)
                snake.transform.eulerAngles = new Vector3(0, 0, 180);
            if (dir == Vector3.down)
                snake.transform.eulerAngles = new Vector3(0, 0, 0);
            if (dir == Vector3.right)
                snake.transform.eulerAngles = new Vector3(0, 0, 90);
            if (dir == Vector3.left)
                snake.transform.eulerAngles = new Vector3(0, 0, -90);
        }
        if (gameObject.layer == LayerMask.NameToLayer("UnPlayer"))
        {
            transform.Translate(dir.x * PSpeed, -dir.y * PSpeed, 0);
            if (dir == Vector3.up)
                snake.transform.eulerAngles = new Vector3(0, 0, 0);
            if (dir == Vector3.down)
                snake.transform.eulerAngles = new Vector3(0, 0, 180);
            if (dir == Vector3.right)
                snake.transform.eulerAngles = new Vector3(0, 0, 90);
            if (dir == Vector3.left)
                snake.transform.eulerAngles = new Vector3(0, 0, -90);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == LayerMask.NameToLayer("wall"))
            SceneManager.LoadScene("GameOver");

        if (collision.gameObject.layer == LayerMask.NameToLayer("Food"))
            SceneManager.LoadScene("Win");
    }

    private void OnSwipe( Vector2 direction)
    {
        dir = direction;
    }
}
