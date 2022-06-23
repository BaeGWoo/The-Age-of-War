using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInformation : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            Destroy(gameObject, 5);
        }
    }


    //게임 오브젝트가 파괴되었을 때 호출되는 함수
    private void OnDestroy()
    {
        
    }
}
