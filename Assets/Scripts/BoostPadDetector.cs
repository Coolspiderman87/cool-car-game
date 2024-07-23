using UnityEngine;

public class BoostPadDetector : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake() => rb = GetComponent<Rigidbody>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out BoostPad boostPad))
        {
            var boostForce = boostPad.GetBoostForce();
            Debug.Log("Hit a boost pad! Boosting with force: " + boostForce);
            rb.AddForce(transform.forward * boostForce, ForceMode.VelocityChange);
        }
    }
}