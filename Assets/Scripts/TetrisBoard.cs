using UnityEngine;

public class TetrisBoard : MonoBehaviour
{
    public int width = 10;
    public int height = 20;
    public Transform boardRoot;
    public GameObject prefabBlock;

    private Transform[][] _grid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _grid = new Transform[height][];
        for (int i = 0; i < height; i++)
        {
            _grid[i] = new Transform[width];
        }
        SpawnTetromino();
    }

    void SpawnTetromino()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
