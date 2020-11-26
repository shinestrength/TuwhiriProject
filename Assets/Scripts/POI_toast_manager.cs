using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI_toast_manager : MonoBehaviour
{
  public void newWorldSuperMarket()
    {
        Toast.Instance.Show("New World SuperMarket 1km away");
        Debug.Log("New World Activated");
    }

   public void whangareiLibrary()
    {
        Toast.Instance.Show("Whangarei Central Library");
        Debug.Log("Whangarei Central Library Activated");
    }

    public void whangareiCouncil()
    {
        Toast.Instance.Show("Whangarei Council Building");
        Debug.Log("Whangarei Council Building Activated");
    }

    public void huntingAndFishing()
    {
        Toast.Instance.Show("Hunting and Fishing");
        Debug.Log("Hunting and Fishing Activated");
    }
}
