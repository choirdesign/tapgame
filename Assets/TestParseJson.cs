using UnityEngine;
using System.Collections;
using LitJson;
using System.IO;
using System;
using System.Text;

public class TestParseJson : MonoBehaviour {
    private string jsonString;
    private JsonData testData;

	// Use this for initialization
	void Start ()
    {
        test();


        jsonString = File.ReadAllText(Application.dataPath + "/Resources/Json/test.txt");
        testData = JsonMapper.ToObject(jsonString);

        string str = (string)testData[1]["name"];
        Debug.Log(str);
        
        //[要素番号]["キー"]でとれた
        //Debug.Log(testData[1]["name"]);
        Debug.Log(testData[1]["attack"]);
	}

    void test()
    {
        System.Text.Encoding src = System.Text.Encoding.ASCII;
        System.Text.Encoding dest = System.Text.Encoding.GetEncoding("Shift_JIS");
        string str = "テスト文章";
        byte[] temp = src.GetBytes(str);
        byte[] sjis_temp = System.Text.Encoding.Convert(src, dest, temp);
        string sjis_str = dest.GetString(sjis_temp);
        Debug.Log("str" + str);
        Debug.Log("sjis_str" + sjis_str);
    }
	
	void TestParse()
    {

    }
}
