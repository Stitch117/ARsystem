using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

public class Target : MonoBehaviour
{
    [SerializeField] Scoretracker m_ScoreTracker;

    private void Awake()
    {
        m_ScoreTracker = FindObjectOfType<XROrigin>().GetComponent<Scoretracker>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ammo"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            m_ScoreTracker.score += 100.0f;
        }
    }
}
