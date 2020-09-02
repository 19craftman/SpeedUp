using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 2;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed * rb.gravityScale, rb.velocity.y);
    }
 
  void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Speed")
        {
            StartCoroutine(speeding());
            Destroy(collision.gameObject);
        }
       
    }
    IEnumerator speeding()
    {
        speed = 5;
        yield return new WaitForSeconds(5);
        speed = 2; 

    }
}
