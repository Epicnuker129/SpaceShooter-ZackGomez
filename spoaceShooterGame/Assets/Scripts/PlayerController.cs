using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    [Header("Attributes")]
    [SerializeField]
    private int health;
    [SerializeField]
    private float speed;

    [Header("Bounds")]
    [SerializeField]
    private float boundMaxX;
    [SerializeField]
    private float boundMinX;
    [SerializeField]
    private float boundMaxY;
    [SerializeField]
    private float boundMinY;

    [Header("Beams")]
    [SerializeField]
    private GameObject laser;

    void Start()
    {
        transform.position = Vector3.zero;

    }

    void Update()
    {
        CalculateMovement();
        ShootLaser();
        if ( health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }
 
    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(-horizontalInput, verticalInput, 0f);
        transform.Translate(speed * Time.deltaTime * direction);
        if (transform.position.y > boundMaxY)
       {
           transform.position = new Vector3(transform.position.x, boundMaxY, 0f);
        }
        else if (transform.position.y < boundMinY)
        {
            transform.position = new Vector3(transform.position.x, boundMinY, 0f);
        }

        if (transform.position.x > boundMaxX)
        {
            transform.position = new Vector3(boundMaxX, transform.position.y, 0f);
        }
        else if (transform.position.x < boundMinX)
        {
            transform.position = new Vector3(boundMinX, transform.position.y, 0f);
        }
    }
    public int GetHP()
    {
        return health;
    }
    public void EnemydamagePlyr()
    {
        Debug.Log("damage player");
        if (health>= 1)
        {
            health -= 1;
        }
    }
    void ShootLaser()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }


}