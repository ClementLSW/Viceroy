using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsInterface : MonoBehaviour
{
    public interface ISkills
    {
        void Activate();
        void CheckCooldown();
        void UpdateUI();
        void AddSkillAmmo();
    }
}
