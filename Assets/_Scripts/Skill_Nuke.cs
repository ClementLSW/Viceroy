using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamagableInterface;
using static SkillsInterface;

public class Skill_Nuke : MonoBehaviour, ISkills
{
    [SerializeField] private float range = 500f;

    private bool coolDown;
    private float coolDownTimer = 10f;
    private float currentCD;
    private int skillAmmo;
    private float maxSkillAmmo;

    public void Activate()
    {
        Debug.Log("Nuke");
        if (!coolDown && skillAmmo > 0)
        {
            Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, range);

            foreach (Collider c in hitColliders)
            {
                foreach (MonoBehaviour mb in c.gameObject.GetComponents<MonoBehaviour>())
                {
                    if (mb is EnemyHealthSystem)
                    {
                        IDamagable hitObj = c.gameObject.GetComponent<IDamagable>();
                        Vector3 pushForce = (mb.transform.position - gameObject.transform.position) * 5f;

                        hitObj.TakeDamage(2f);
                        hitObj.ApplyPushForce(pushForce);

                        Debug.Log(c.gameObject.name);
                    }
                }
            }
            coolDown = true;
            currentCD = coolDownTimer;
        }
    }

    // On Pickup call this
    public void AddSkillAmmo()
    {
        if (skillAmmo < maxSkillAmmo)
        {
            skillAmmo++;
        }
    }

    public void CheckCooldown()
    {
        if (currentCD > 0)
        {
            currentCD -= Time.deltaTime;
        }
        else
        {
            coolDown = false;
        }
    }

    public void UpdateUI()
    {
        //if (coolDown)
        //{
        //    skillIconCDFilter.fill = (currentCD / coolDownTimer);
        //}
        //else
        //{
        //    skillIconFilter.show
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        //coolDown = false;
        //skillAmmo = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        //if (coolDown)
        //{
        //    CheckCooldown();
        //}
        //UpdateUI();
    }
}
