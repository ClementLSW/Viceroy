using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamagableInterface;
using static SkillsInterface;

public class Skill_Nuke : MonoBehaviour, ISkills
{
    [SerializeField] private float range = 5f;

    private bool coolDown;
    private float coolDownTimer = 10f;
    private float currentCD;
    private float skillAmmo;
    private float maxSkillAmmo;
    
    public void Activate()
    {
        if (!coolDown && skillAmmo>0)
        {
            Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, range);

            foreach(Collider c in hitColliders)
            {
                IDamagable hitObj = c.gameObject.GetComponent<IDamagable>();
                if (hitObj != null)
                {
                    hitObj.TakeDamage(2f);
                    c.GetComponent<Rigidbody>().AddForce((c.transform.position - gameObject.transform.position) * 5f);
                }
                Destroy(gameObject);
            }

            coolDown = true;
            currentCD = coolDownTimer;
        }
    }

    // On Pickup call this
    public void AddSkillAmmo()
    {
        if(skillAmmo < maxSkillAmmo)
        {
            skillAmmo += 1;
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
        skillAmmo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (coolDown) CheckCooldown();
        UpdateUI();
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
