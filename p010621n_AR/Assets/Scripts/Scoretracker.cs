using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class Scoretracker : MonoBehaviour
{
    [SerializeField] TMP_Text m_score;
    public float score;


    // Update is called once per frame
    void Update()
    {
        m_score.text = "Score: " + score.ToString();
    }
}
