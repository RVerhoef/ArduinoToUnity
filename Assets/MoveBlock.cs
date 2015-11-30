using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class MoveBlock : MonoBehaviour
{


    SerialPort stream = new SerialPort("COM5", 9600);
    string[] strArr;
    int x = 0;
    int y = 0;

    // Use this for initialization
    void Start()
    {
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        strArr = stream.ReadLine().Split("|"[0]);
        Debug.Log("x " + strArr[0] +  " y " + strArr[1]);
        if (int.Parse(strArr[0]) < 250)
        {
            x = 1;
        }
        else if(int.Parse(strArr[0]) > 850)
        {
            x = -1;
        }
        else
        {
            x = 0;
        }
        if (int.Parse(strArr[1]) < 250)
        {
            y = -1;
        }
        else if (int.Parse(strArr[1]) > 850)
        {
            y = 1;
        }
        else
        {
            y = 0;
        }

        Debug.Log(new Vector2(x,y));
        
        
    }
    void FixedUpdate()
    {
        transform.Translate(new Vector2(x * Time.smoothDeltaTime, y * Time.smoothDeltaTime));
    }
}
