using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject playerPrefab;

    int[,] map;
    GameObject[,] field;

      // Start is called before the first frame update
    void Start()
    {
       /* GameObject instance = Instantiate(
            playerPrefab,
            new Vector3(0, 0, 0),
            Quaternion.identity);*/

        map = new int[,]
        {
        {0,0,0,0,0},
        {0,0,1,0,0},
        {0,0,0,0,0}
        };

        field = new GameObject[
            map.GetLength(0),
            map.GetLength(1)
            ];

        string debugText="";
        for(int y = 0; y < map.GetLength(0); y++)
        {
            for(int x = 0; x < map.GetLength(1); x++)
            {
                if (map[y,x] == 1)
                {
                    field[y,x] = Instantiate(
                        playerPrefab,
                        new Vector3(x,map.GetLength(0)-1-y,0.0f),
                        Quaternion.identity
                        );
                }
               /* else
                {
                    GameObject instance = Instantiate(
                       playerPrefab,
                       new Vector3(x, map.GetLength(0) - 1 - y, 0.0f),
                       Quaternion.identity
                       );
                }*/
            }
           // debugText += "\n";
        }
        //Debug.Log(debugText);
       // PrintArray();


    }

   /* void PrintArray()
    {
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }*/
   
    /*
    private Vector2Int GetPlayerIndex()
    {
        for (int y = 0; i < map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }
        }
        return new Vector2Int(-1,-1);
    }
    
    bool MoveNumber(string objN, int moveFrom, int moveTo)
    {
        if (moveTo < 0 || moveTo >= map.Length)

            return false;
    }
    int velocity = moveTo - moveFrom;

    bool success = MoveNumber(2, moveTo, moveTo + velocity);

    if(!success){return false;}
        {
        map[moveTo] = number;
        map[moveFrom] = 0;
        return true;
}
    }*/

/*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int playerIndex = GetPlayerIndex();

        MoveNumber(1, playerIndex, playerIndex + 1);


            PrintArray();
        }
    }*/
}