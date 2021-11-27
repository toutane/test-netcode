using UnityEngine;
using Unity.Netcode;

public class CommandLineInterface : MonoBehaviour
{
    private void Awake() {
        string[] args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++) {
            if (args[i] == "-launch-as-server") {
                NetworkManager.Singleton.StartServer();
            }
            else if (args[i] == "-launch-as-host") {
                NetworkManager.Singleton.StartHost();
            }
            else if (args[i] == "-launch-as-client") {
                NetworkManager.Singleton.StartClient();
            }
        }
    }
}
