using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericCard : ScriptableObject {
    public string CharacterName;

    [Range(0, 20000)]
    public int Attack;

    [Range(0, 20000)]
    public int HP;

    [SerializeField] public
    SpellType SpellOne = new SpellType();
    [SerializeField] public
    SpellType SpellTwo = new SpellType();
    [SerializeField] public
    SpellType SpellThree = new SpellType();

    public Texture CardArt;
    public Texture CardBorder;
    public Texture CardBack;
}

[CreateAssetMenu(menuName = "TWST/Card Data")]
public class CardData : GenericCard {
    [SerializeField] public
    CardRarity Rarity = new CardRarity();
    public string CardType;
}

public class EnemyCard : GenericCard
{
    [SerializeField] public
    NPCDifficulty Difficulty = new NPCDifficulty();
}

[Serializable]
public enum SpellType
{
    None,
    Cosmic,
    Fire,
    Water,
    Grass
}

[Serializable]
public enum CardRarity
{
    SSR,
    SR,
    R
}

[Serializable]
public enum NPCDifficulty
{
    Easy,
    Normal,
    Hard,
    VeryHard
}
