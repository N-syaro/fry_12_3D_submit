using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject clearPanel;
    [SerializeField]
    Text E_text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clearPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemis = GameObject.FindGameObjectsWithTag("Enemy");
        E_text.text = "EnemyCount : "+enemis.Length;
        if(enemis.Length < 0)
        {
            clearPanel.SetActive(true);
        }
    }
}
