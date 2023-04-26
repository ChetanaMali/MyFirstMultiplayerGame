using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float pSpeed = 30f;
    [SerializeField] Rigidbody2D rb2D;
    
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal") * pSpeed * Time.deltaTime;
        movement.y = Input.GetAxisRaw("Vertical") * pSpeed * Time.deltaTime;
        /*Vector3 player;
        player = transform.position;
        player.x = Mathf.Clamp(player.x, 8.15f, -8.15f);
        player.y = Mathf.Clamp(player.y, 4.25f, -4.25f);
        //transform.position = player; 
        */
    }
    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + movement);
        //transform.position = transform.position + new Vector3(movement.x, movement.y, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {  
            Destroy(collision.gameObject);
            GameManager.Instance.CollectingCoins();
        }
        if (collision.tag == "BigCoin")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.CollectingBigCoins();
        }
    }
}
