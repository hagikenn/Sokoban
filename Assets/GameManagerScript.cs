using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject boxPrefab;

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
        {0,2,0,0,0},
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
                if (map[y, x] == 2)
                {
                    field[y, x] = Instantiate(
                        boxPrefab,
                        new Vector3(x, map.GetLength(0) - 1 - y, 0.0f),
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

   


    //int GetPlayerIndex()
    //{
    //    for (int y = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}
    
    private Vector2Int GetPlayerIndex()
    {
        for (int y = 0; y < field.GetLength(0); y++)
        {
            for(int x = 0; x < field.GetLength(1); x++)
            {
                if (field[y,x]==null) { continue; }

                if (field[y,x].tag=="Player")
                {
                    return new Vector2Int(x,y);
                }
            }
            
        }
        return new Vector2Int(-1, -1);
    }
    
    bool MoveNumber(Vector2Int moveFrom,Vector2Int moveTo)
    {
        if (moveTo.y < 0 || moveTo.y >= field.GetLength(0)) { return false; }
        if (moveTo.x < 0 || moveTo.x >= field.GetLength(1)) { return false; }
        
        if (field[moveTo.y, moveTo.x] != null && field[moveTo.y,moveTo.x].tag=="Box")
        {
            Vector2Int velocity = moveTo - moveFrom;
            bool success = MoveNumber(moveTo, moveTo + velocity);
            if (!success) { return false; }
        }

       
        
        field[moveTo.y, moveTo.x] = field[moveFrom.y,moveFrom.x];
        field[moveFrom.y, moveFrom.x].transform.position =
            new Vector3(moveTo.x, map.GetLength(0)-moveTo.y, 0);
        field[moveFrom.y, moveFrom.x] = null;
        return true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2Int playerIndex = GetPlayerIndex();

        MoveNumber(playerIndex, playerIndex + new Vector2Int(1,0));


           // PrintArray();
        }
    }
}