using UnityEngine;
using UnityEngine.XR.ARFoundation;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class FireProjectile : MonoBehaviour
{
    [SerializeField] private GameObject m_projectile;
    private ARRaycastManager m_raycastManager;
    [SerializeField] private float m_projectileSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_raycastManager = GetComponent<ARRaycastManager>();
    }

    private void OnEnable()
    {
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown += FingerDown;
    }

    private void OnDisable()
    {
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.EnhancedTouchSupport.Disable();
        EnhancedTouch.Touch.onFingerDown -= FingerDown;
    }

    private void FingerDown(EnhancedTouch.Finger finger)
    {
        if (finger.index != 0) return;

        GameObject projectile = Instantiate(m_projectile);
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(finger.currentTouch.screenPosition);
            rigidbody.AddForce(ray.direction * m_projectileSpeed, ForceMode.Impulse);
        }
    }
}
