using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;
public class Test : MonoBehaviour {

    //public GameObject text;
    //EnemyData[] ene;
    private Dictionary<int, int> aaa;
    // Use this for initialization
    void Start () {
        aaa = new Dictionary<int, int>();
        aaa.Add(1,1);
        aaa.Remove(1);
        Debug.Log(aaa.ContainsKey(1));
        
        //Debug.Log(Const.JsonPath);

    }
    bool isCopy = true;
	// Update is called once per frame
	void Update () {
        
	}
}
