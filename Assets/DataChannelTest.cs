using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.WebRTC;

public class DataChannelTest : MonoBehaviour
{

    public GameObject dataChannelTestPrefab;
    public int numberOfDataChannelTests = 2;

    void Awake()
    {
        WebRTC.ConfigureNativeLogging(true, NativeLoggingSeverity.Info);
        
        for (int i = 0; i < numberOfDataChannelTests; i++)
        {
            GameObject dataChannelTest = Instantiate(dataChannelTestPrefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity, transform);
            dataChannelTest.name = "Test" + i;
        }
    }
}
