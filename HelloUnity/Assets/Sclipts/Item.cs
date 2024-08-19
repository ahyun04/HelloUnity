using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //맴버 변수 정의 
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;


    private void Awake()
    {
        Debug.Log("Awake메서드 호출됨!");

        Debug.Log($"아이템명 : {this.itemName}");
        Debug.Log($"공격력 : {this.damage}");
        Debug.Log($"공격속도 : {this.attackSpeed}");
        Debug.Log($"파괴여부 : {this.isBroken}");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start메서드 호출됨!");
    }

    // Update is called once per frame
    void Update()
    {
        //주석 : 컨트롤 + K + C 
        //주석 풀기 : 컨트롤 + K + U
        //Debug.Log("Update");
    }
}
