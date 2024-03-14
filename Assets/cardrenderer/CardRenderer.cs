using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardRenderer : MonoBehaviour
{
    // Start is called before the first frame update
    public CardData CardToRender;
    private Renderer thisRenderer;
    private MaterialPropertyBlock mbp;

    public TextMeshProUGUI CharaName;
    public TextMeshProUGUI CardType;
    public TextMeshProUGUI CardRarity;
    public TextMeshProUGUI CardSpells;
    public TextMeshProUGUI HPField;
    public TextMeshProUGUI ATKField;

    // Update is called once per frame
    void Awake()
    {
        thisRenderer = GetComponent<Renderer>();
        mbp = new MaterialPropertyBlock();
    }

    // WRT the CardArt code, it will defnitely be possible to change the card border and back...at least i hope
    // update: it works :thumbs_up:
    public void OnValidate()
    {
        if (mbp == null) mbp = new MaterialPropertyBlock();
        if (thisRenderer == null) thisRenderer = GetComponent<Renderer>();

        mbp.SetTexture("_CardArt", CardToRender.CardArt);
        mbp.SetTexture("_CardBack", CardToRender.CardBack);
        mbp.SetTexture("_CardBorder", CardToRender.CardBorder);

        if (CharaName != null && CardType != null && CardRarity != null && CardSpells != null
            && HPField != null && ATKField != null) {
            CharaName.text = CardToRender.CharacterName;
            CardType.text = CardToRender.CardType;
            CardRarity.text = CardToRender.Rarity.ToString();
            CardSpells.text = CardToRender.SpellOne.ToString() + " / "
                + CardToRender.SpellTwo.ToString() + " / " + CardToRender.SpellThree.ToString();
            HPField.text = "HP: " + CardToRender.HP.ToString();
            ATKField.text = "ATK: " + CardToRender.Attack.ToString();
        }

        thisRenderer.SetPropertyBlock(mbp);
    }
}
