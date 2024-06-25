using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button buttonHost;
    [SerializeField] private Button buttonJoin;

    private void Awake() {
        buttonHost.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
        });
        buttonJoin.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        });
    }

    void Update()
    {
        
    }
}
