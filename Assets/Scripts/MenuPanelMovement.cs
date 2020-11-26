using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelMovement : MonoBehaviour
{

    public GameObject MenuOrigPos;
    public GameObject MenuActivePos;
    public GameObject MenuPanel;

    //make the below private to hide in inspector
    public bool Move_Menu_Panel;
    public bool Move_Menu_Panel_Back;

    public float transitionSpeed;
    //make the below private to remove from inspector
    public float tempMenuPOS;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.transform.position = MenuOrigPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Move_Menu_Panel == true)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuActivePos.transform.position, transitionSpeed * Time.deltaTime);

            if(MenuPanel.transform.localPosition.x == tempMenuPOS)
            {
                Move_Menu_Panel = false;
                MenuPanel.transform.position = MenuActivePos.transform.position;
                tempMenuPOS = -9999999999999.99f;
            }
            if(Move_Menu_Panel == true)
            {
                tempMenuPOS = MenuPanel.transform.position.x;
            }
        }

        if (Move_Menu_Panel_Back)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuOrigPos.transform.position, transitionSpeed * Time.deltaTime);

            if (MenuPanel.transform.localPosition.x == tempMenuPOS)
            {
                Move_Menu_Panel_Back = false;
                MenuPanel.transform.position = MenuOrigPos.transform.position;
                tempMenuPOS = -9999999999999.99f;
            }
            if (Move_Menu_Panel_Back == true)
            {
                tempMenuPOS = MenuPanel.transform.position.x;
            }
        }
    }

    public void MovePanel()
    {
        Move_Menu_Panel_Back = false;
        Move_Menu_Panel = true;

        Debug.Log("Move_Menu_Panel = " + Move_Menu_Panel + "      Move_Menu_Panel_Back =" + Move_Menu_Panel_Back);
    }

    public void MovePanelBack()
    {
        Move_Menu_Panel = false;
        Move_Menu_Panel_Back = true;

        Debug.Log("Move_Menu_Panel = " + Move_Menu_Panel + "      Move_Menu_Panel_Back =" + Move_Menu_Panel_Back);
    }
}
