using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private Rigidbody2D _rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(3, -2);

        //Invoke(nameof(AcceptDefeat), 12);

        _rigidbody = GetComponent<Rigidbody2D>();

        _rigidbody.velocity = Vector2.right * 5f;

    }

    void AcceptDefeat()
    {

        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
