using UnityEngine;

namespace WalletConnect.Web3Modal.HdrpSample
{
    public class Dapp : MonoBehaviour
    {
        public async void Start()
        {
            await Web3Modal.InitializeAsync();
            
            Web3Modal.ModalController.OpenStateChanged += (sender, args) =>
            {
                Debug.Log($"Show cursor: {args.IsOpen}");
                Cursor.visible = args.IsOpen;
                Cursor.lockState = args.IsOpen ? CursorLockMode.None : CursorLockMode.Locked;
            };
        }
    }
}