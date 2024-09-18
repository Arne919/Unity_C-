using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSkill
{
    public PokemonSkill(string _name, float _damage, Pokemon.eType _type)
    {
        name = _name;
        damage = _damage;
        type = _type;
    }

    public string name;
    public float damage;
    public Pokemon.eType type;

}
