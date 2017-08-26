using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

  public GameManager gameManager;
  public Rigidbody2D rb;
  public float jumpforce;

  public float speed = 0;
  // Use this for initialization
  void Start () {
    rb = GetComponent<Rigidbody2D>();
  }
	
  // Update is called once per frame
  void Update () {

    float keyboardInputX;
    float keyboardInputY;

    keyboardInputX = Input.GetAxis("Horizontal");
    keyboardInputY = Input.GetAxis("Vertical");
    transform.Translate(new Vector2(keyboardInputX * speed * Time.deltaTime, 0));

    if (Input.GetKey(KeyCode.Space)) {
      rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Force);
    }
  }

  private void OnTriggerEnter2D(Collider2D collider)
  {
    if (collider.tag == "coin")
    {

      gameManager.addScore();
      Destroy(collider.gameObject);

    }
    if (collider.tag == "spike")
    {
      gameManager.LooseLife();
    }
  }
}


//space key for moving upwards and right arrow key for moving right