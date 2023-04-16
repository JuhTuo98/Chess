using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    string[] letters = {"A", "B", "C", "D", "E", "F", "G", "H"};
    public GameObject King;
    public GameObject Queen;
    public GameObject Rook;
    public GameObject Bishop;
    public GameObject Knight;
    public GameObject Pawn;

    public GameObject[] pieces;
    public ChessPiece.Cell[,] board;

    public enum ChessType
    {
        King = 0, Queen = 1, Rook = 2,
        Bishop = 3, Knight = 4, Pawn = 5
    };

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null) Destroy(gameObject);
        else instance = this;

        pieces = new GameObject[32];
        board = new ChessPiece.Cell[8,8];

        Initialize();
    }

    void Initialize()
    {
        for (int x = 0; x < board.GetLength(0); x++)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                board[x,y] = new ChessPiece.Cell(letters[x], y+1);
                pieces[x+y] = Instantiate(King);
                pieces[x+y].GetComponent<ChessPiece>().cell = board[x,y];
            }
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
