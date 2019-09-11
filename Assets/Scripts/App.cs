using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    [SerializeField]
    private Image m_Image;
    private Heart heart;

    private void Start()
    {
        heart = new Heart(m_Image);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            heart.Replenish(1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            heart.Deplete(1);           
        }
    }
}
