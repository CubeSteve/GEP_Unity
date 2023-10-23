using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    //The ItemsCSV file
    public TextAsset itemsCSV;

    //Stored item list
    private string[] itemList;

    //Columns
    //ID	Name	Value   Weight
    //private int COLUMNS = 4;

    void Start()
    {
        ReadCSV();
    }

    void ReadCSV()
    {
        itemList = itemsCSV.text.Split(new string[] { "\n" }, System.StringSplitOptions.None);
    }

    public string[] getItemByID(int id)
    {
        /*
         * Returns an array of attributes (ID,Name,Value,Weight as of writing) from the given ID
         */
        string[] itemAttributes = itemList[id].Split(new string[] { "," }, System.StringSplitOptions.None);
        return itemAttributes;
    }

}
