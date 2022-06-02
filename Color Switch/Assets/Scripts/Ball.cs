using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Color[] colors = new Color[4];
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BallMovement();
    }

    void BallMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            rb.AddForce(new Vector2(0f, speed));
            
    }
  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != text.text)
        {
            Debug.Log("dead");
            Time.timeScale = 0;
            Debug.Log(collision.tag);
            Debug.Log(collision.transform.position);
        }
        else
        {
            switch (collision.tag)
            {
                case "CYAN":
                    transform.gameObject.GetComponent<SpriteRenderer>().color = colors[0];
                    break;
                case "PINK":
                    transform.gameObject.GetComponent<SpriteRenderer>().color = colors[1];
                    break;
                case "PURPLE":
                    transform.gameObject.GetComponent<SpriteRenderer>().color = colors[2];
                    break;
                case "YELLOW":
                    transform.gameObject.GetComponent<SpriteRenderer>().color = colors[3];
                    break;
            }
        }
    }
}
