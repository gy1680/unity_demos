using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class JSBridgeDemo : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void HelloString(string str);

    public Text jsMessage;
    //点击按钮,unity调用js方法
    public void Send2JSMessage(string msg)
    {
#if UNITY_WEBGL
        HelloString(msg);
#endif
    }

    //js调用unity方法
    public void OnJsCallUnity(string msg)
    {
#if UNITY_WEBGL
        jsMessage.text = msg;
#endif
    }
}
