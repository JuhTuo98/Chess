using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    public static ChessPiece instance;
    public GameManager.ChessType type;

    public Cell cell;

    public struct Cell
    {
        public Cell(string x, int y)
        {
            X = x;
            Y = y;
        }

        public string X {set; get; }
        public int Y {set; get; }

        public override string ToString() => $"{X}{Y}";
    }

    // Start is called before the first frame update
    void Start()
    {   
        if (instance != null) Destroy(gameObject);
        else instance = this;

        name = type.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
