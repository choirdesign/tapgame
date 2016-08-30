using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FooterButton : MonoBehaviour {

    public void OnPush ()
    {
        string str = this.gameObject.name;

        switch (str)
        {
            case "BtnMyPage":
                Debug.Log("マイペ");
                break;
            case "BtnStatus":
                Debug.Log("ステ");
                break;
            case "BtnDungeon":
                Debug.Log("ダンジョン");
                break;
            case "BtnBook":
                Debug.Log("図鑑");
                break;
            case "BtnConfig":
                Debug.Log("設定");
                break;
            default:
                break;


        }


    }

}
