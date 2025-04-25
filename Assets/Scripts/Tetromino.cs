using UnityEngine;

public class Tetromino : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float fallTime = 1.0f;
    
    private float _previousTime;
    private TetrisBoard _tetrisBoard; 
    void Start()
    {
        _tetrisBoard = Object.FindFirstObjectByType<TetrisBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - _previousTime > fallTime)
        {
            transform.position += Vector3.down * 32; 
            _previousTime = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * 32;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * 32;
        }
        
    }
}
