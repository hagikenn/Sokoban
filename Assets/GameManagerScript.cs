using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //�z��̐錾
    int[] map;

    // Start is called before the first frame update
    void Start()
    {

        //�ύX�m�F�������Ƃ���CTRL�L�[+S�L�[

        //�f�o�b�N���O�̏o��
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
