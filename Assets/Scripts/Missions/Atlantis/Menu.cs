using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Sprite p24;
    public Sprite p26;
    public Sprite p27;
    public Sprite p30;
    public Sprite p31;

    public Image OrderConfirmImage;
    public UIMissionPanel OrderConfirmPanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Order(int menu)
    {
        switch (menu)
        {
            case 1:
                OrderConfirmImage.sprite = p24;
                break;
            case 2:
                OrderConfirmImage.sprite = p26;
                break;
            case 3:
                OrderConfirmImage.sprite = p27;
                break;
            case 4:
                OrderConfirmImage.sprite = p30;
                break;
            default:
                OrderConfirmImage.sprite = p31;
                break;
        }
        OrderConfirmPanel.Open();
    }
}
