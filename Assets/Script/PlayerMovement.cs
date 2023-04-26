using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviourPunCallbacks
{
    [SerializeField] float pSpeed = 30f;
    [SerializeField] Rigidbody2D rb2D;
    PhotonView view;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
        movement.x = Input.GetAxisRaw("Horizontal") * pSpeed * Time.deltaTime;
        movement.y = Input.GetAxisRaw("Vertical") * pSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(movement.x, movement.y, 0f);
        }
        /*Vector3 player;
        player = transform.position;
        player.x = Mathf.Clamp(player.x, 8.15f, -8.15f);
        player.y = Mathf.Clamp(player.y, 4.25f, -4.25f);
        //transform.position = player; 
        */
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
