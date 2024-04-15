using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //配列の宣言
    int[] map;

    // Start is called before the first frame update
    void Start()
    {

        //変更確認したいときはCTRLキー+Sキー

        //デバックログの出力
        //Debug.Log("Hello World");

        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, };

        string debugText = "";

        for(int i=0;i<map.Length;i++)
        {
            debugText += map[i].ToString()+",";
        }
        Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
