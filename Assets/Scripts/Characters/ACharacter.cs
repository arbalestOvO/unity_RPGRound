using System;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Rendering;

[ManageableData]
[Serializable]
public class ACharacter : ScriptableObject
{
    [Tooltip("名字")]
    public string name;
    [Tooltip("阵营")]
    public Camp camp;
    [Tooltip("属性")]
    public CProperty cProperty;
    [Tooltip("是否有控制BUFF")]
    public SerializedDictionary<string, bool> has_ccBUFF;
    [Tooltip("是否有增益BUFF")]
    public SerializedDictionary<string, bool> has_beBUFF;
    [Tooltip("是否有减益BUFF")]
    public SerializedDictionary<string, bool> has_deBUFF;    
    [Tooltip("技能槽")]
    public SerializedDictionary<string, ASkill> dic_skill;
    [Tooltip("物品槽")]
    public SerializedDictionary<string, AItem> dic_item;
    [Tooltip("角色当前状态")]
    public CharacterState characterState;
    [Tooltip("角色当前行动点")]
    public int actionPoint;
    [Tooltip("角色动画控制器")]
    public AnimatorController animatorController;
}

[Serializable]
public class CProperty
{
    [Tooltip("生命值")]
    public int hp;
    [Tooltip("物攻")]
    public int atk;
    [Tooltip("魔攻")]
    public int matk;
    [Tooltip("物防")]
    public int def;
    [Tooltip("魔防")]
    public int mdef;
    [Tooltip("敏捷")]
    public int agi;
    [Tooltip("暴击")]
    public int cri;
    [Tooltip("升级点数")]
    public int point;
}
[Serializable]
public abstract class ASkill : ScriptableObject
{
    [Tooltip("技能名字")]
    public string name;
    [Tooltip("技能图标")]
    public Sprite icon;
    [Tooltip("技能描述")]
    public string description;
    [Tooltip("技能消耗行动点")]
    public int cost;
    [Tooltip("技能冷却")]
    public float cd;
    [Tooltip("是否可用")]
    public bool isAvailable;
    [Tooltip("施放特效")]
    public ParticleSystem effect;
    [Tooltip("击中特效")]
    public ParticleSystem hitEffect;
    [Tooltip("技能音效")]
    public AudioClip audio;

    public abstract void Effect(GameObject origin);
}

[Serializable]
public abstract class AItem : ScriptableObject
{
    [Tooltip("物品名字")]
    public string name;
    [Tooltip("物品图标")]
    public Sprite icon;
    [Tooltip("物品描述")]
    public string description;
    [Tooltip("物品类型")]
    public ItemType itemType;
    [Tooltip("物品消耗行动点")]
    public int cost;
    [Tooltip("是否可用")]
    public bool isAvailable;
    [Tooltip("使用特效")]
    public ParticleSystem effect;
    [Tooltip("使用音效")]
    public AudioClip audio;

    public abstract void Trigger(GameObject origin);
}
