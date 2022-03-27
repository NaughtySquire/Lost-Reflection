using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    [SerializeField]
    float PSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameObject.layer == LayerMask.NameToLayer("Player"))
            transform.Translate(Input.GetAxis("Horizontal") * PSpeed, Input.GetAxis("Vertical") * PSpeed, 0);
        if (gameObject.layer == LayerMask.NameToLayer("UnPlayer"))
            transform.Translate(Input.GetAxis("Horizontal") * PSpeed, -Input.GetAxis("Vertical") * PSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("wall"))
            SceneManager.LoadScene("GameOver");

        if (collision.gameObject.layer == LayerMask.NameToLayer("Food"))
            SceneManager.LoadScene("Win");
    }
}
