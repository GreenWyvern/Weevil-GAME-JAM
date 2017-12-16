using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // PUBLIC INSTANCE VARIABLES
    public GamePlayScene gameController;
    public Boundary boundary;
    public bool isColliding;

    public float height;
    public float width;
    public float halfheight;
    public float halfwidth;

    public float speed;

    // PRIVATE INSTANCE VARIABLES
    private float _dx;
    private float _dy;
    private float _direction;


    // Use this for initialization
    void Start()
    {
        this.height = gameObject.GetComponent<Renderer>().bounds.extents.y;
        this.width = gameObject.GetComponent<Renderer>().bounds.extents.x;
        this.halfheight = this.height * 0.5f;
        this.halfwidth = this.width * 0.5f;

        this._reset();
        this.speed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        // Comment out the following if you don't want the player to follow the mouse
        this._playerFollowMouse();
        this._playerMove();
        this._checkBounds();
    }

    // PRIVATE METHODS

    private void _reset()
    {
        transform.position = new Vector2(0.0f, -3.6f);
    }

    private void _playerFollowMouse()
    {
        float mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        float mouseY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        this._dx = 0 - transform.position.x;
        this._dy = 0 - transform.position.y;
        // find the angle of rotation

        this._direction = Mathf.Atan2(this._dy, this._dx) * Mathf.Rad2Deg  - 90.0f;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, this._direction));
    }

    private void _playerMove()
    {
        // Uncomment the following for Normal Movement
        /*
        if (Input.GetAxis("Horizontal") > 0.2)
        {
            transform.position = new Vector2(transform.position.x + this.speed, transform.position.y);
        }
        if (Input.GetAxis("Horizontal") < -0.2)
        {
            transform.position = new Vector2(transform.position.x - this.speed, transform.position.y);
        }
        if (Input.GetAxis("Vertical") > 0.2)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + this.speed);
        }
        if (Input.GetAxis("Vertical") < -0.2)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - this.speed);
        }
        */

        // comment out the following if you want Normal player movement
        float newDirection = (this._direction -90.0f) * -1.0f;

            if (Input.GetAxis("Horizontal") > 0.2)
            {
            transform.position = new Vector2(
                transform.position.x + (this.speed * Mathf.Sin(newDirection * Mathf.Deg2Rad)),
                transform.position.y + (this.speed * Mathf.Cos(newDirection * Mathf.Deg2Rad)));
            }
            if (Input.GetAxis("Horizontal") < -0.2)
            {
                transform.position = new Vector2(
                    transform.position.x - (this.speed * Mathf.Sin(newDirection * Mathf.Deg2Rad)),
                    transform.position.y - (this.speed * Mathf.Cos(newDirection * Mathf.Deg2Rad)));
            }


    }

    private void _checkBounds()
    {
        if (transform.position.x >= boundary.Right - this.halfwidth)
        {
            transform.position = new Vector2(boundary.Right - this.halfwidth, transform.position.y);
        }

        if (transform.position.x <= boundary.Left + this.halfwidth)
        {
            transform.position = new Vector2(boundary.Left + this.halfwidth, transform.position.y);
        }

        if (transform.position.y >= boundary.Top - this.halfheight)
        {
            transform.position = new Vector2(transform.position.x, boundary.Top - this.halfheight);
        }

        if (transform.position.y <= boundary.Bottom + this.halfheight)
        {
            transform.position = new Vector2(transform.position.x, boundary.Bottom + this.halfheight);
        }
    }
}
