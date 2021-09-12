using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Attributes

    [HideInInspector]
    public Vector3 initialPosition;
    public int speed = 5;

    #endregion


    #region Private Attributes

    [SerializeField]
    float horizontalInput;
    bool paused;

    #endregion


    #region Monobehaviour Methods

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    //FixedUpdate is called once every X miliseconds (No depende del framerate)
    private void FixedUpdate()
    {
        Move(horizontalInput);
    }

    #endregion


    #region Public Methods

    public void Move(float x)
    {
        
        Vector2 velocity = new Vector2(x, 0);
        transform.Translate(speed * Time.deltaTime * velocity);
    }

    public void CheckInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        

        if (Input.GetButton("Run"))
        {
            Run();
        }
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (Input.GetButtonDown("Pause"))
        {
            Pause();
        }
        if (Input.GetButton("Defend"))
        {
            Defend();
        }
        if (Input.GetButtonUp("Defend"))
        {
            Push();
        }
    }

    private void Push()
    {
        throw new NotImplementedException();
    }

    private void Defend()
    {
        throw new NotImplementedException();
    }

    private void Pause()
    {
        if(paused) Time.timeScale = 1;
        if(!paused) Time.timeScale = 0;
        paused = !paused;

    }

    private void Jump()
    {
        throw new NotImplementedException();
    }

    private void Run()
    {
        throw new NotImplementedException();
    }

    #endregion
}
