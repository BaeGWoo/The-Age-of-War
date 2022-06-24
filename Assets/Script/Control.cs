using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    int damage = 10;

    public float speed;
    public int health = 100;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // 애니메이터 컨트롤러에서 현재 애니메이터의 상태의 이름이“attack1”일 때 
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("attack1"))
        {
            // 현재 애니메이션의 진행도가 1보다 크거나 같다면 User Interface를 비활성화하도록 설계하였습니다.
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                health -= 10;
               animator.Rebind();
            }
        }

        if(health<=0)
        {
            Destroy(gameObject);
        }


        RaycastHit hit;

      

        Ray ray=new Ray(transform.position,transform.forward);
        
        if(Physics.Raycast(ray,out hit,1.5f))
        {
            speed = 0.0f;
            animator.SetBool("Attack", true);
        }

        else
        {
            speed = 3.0f;
            animator.SetBool("Attack", false);
        }

        Debug.DrawRay(transform.position, transform.forward * 1.5f);
    }

   
   
}
