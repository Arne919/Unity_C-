using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CloseWeaponController : MonoBehaviour //미완성 클래스(추상 클래스)
{
    //현재 장착된 Hand형 타입 무기
    [SerializeField]
    protected CloseWeapon currentCloseWeapon;

    //공격중
    protected bool isAttack = false;
    protected bool isSwing = false;

    protected RaycastHit hitInfo;


    protected void TryAttack()
    {
        if (Input.GetButton("Fire1")) //왼버튼
        {
            if (!isAttack)
            {//코루틴 실행
                StartCoroutine(AttackCoroutine());

            }
        }
    }

    protected IEnumerator AttackCoroutine()
    {
        isAttack = true; //중복시행 막음
        currentCloseWeapon.anim.SetTrigger("Attack"); //공격모션시행

        yield return new WaitForSeconds(currentCloseWeapon.attackDelayA);
        isSwing = true;

        StartCoroutine(HitCoroutine());
        //공격 활성화 시점

        yield return new WaitForSeconds(currentCloseWeapon.attackDelayB);
        isSwing = false;

        yield return new WaitForSeconds(currentCloseWeapon.attackDelay - currentCloseWeapon.attackDelayA - currentCloseWeapon.attackDelayB);
        isAttack = false;
    }

    //미완성 = 추상 코루틴(자식클래스에서 완성하자)
    protected abstract IEnumerator HitCoroutine();


    protected bool CheckObject()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, currentCloseWeapon.range))
        {
            return true;
        }
        return false;
    }

    //완성 함수이지만, 추가 편집이 가능한 함수
    public virtual void CloseWeaponChange(CloseWeapon _CloseWeapon)
    {
        if (WeaponManager.currentWeapon != null)
            WeaponManager.currentWeapon.gameObject.SetActive(false);

        currentCloseWeapon = _CloseWeapon;
        WeaponManager.currentWeapon = currentCloseWeapon.GetComponent<Transform>();
        WeaponManager.currentWeaponAnim = currentCloseWeapon.anim;


        currentCloseWeapon.transform.localPosition = Vector3.zero;
        currentCloseWeapon.gameObject.SetActive(true);

    }
}
