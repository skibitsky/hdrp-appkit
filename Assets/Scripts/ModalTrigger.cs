using UnityEngine;

namespace WalletConnect.Web3Modal.HdrpSample
{
    public class ModalTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider _)
        {
            Web3Modal.OpenModal();
        }
    }
}