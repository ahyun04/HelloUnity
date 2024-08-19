using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //큐브의 위치를 출력
        //클래스의 현재 인턴스
        //CubeController의 인스턴스
        //변수타입 변수이름
        Transform transform = this.gameObject.GetComponent<Transform>();

        //CubeController 컴포넌트가 붙어있는 게임오브젝트의 Transform 컴포넌트의 ㅔㅐsition값 반환
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);

        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.position);
        //this.transform.position = this.transform.position + new Vector3(1, 0, 0);
        this.transform.position += new Vector3(0, 0, 0.01f);
    }
}
