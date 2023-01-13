using Problem_7.Gems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Problem_7
{
    internal class Weapon
    {
        private string _name;
        private string _type;
        private BaseGem?[] _gamesSoket;
        private int _damage;
        private string _rarity;
        private int _Strength = 0;
        private int _Agility = 0;
        private int _Vitality = 0;

        public string Type { get { return _type; } }
        public string Name { get { return _name; } }
        public string Rarity { get { return _rarity; } }

        public Weapon(string name, string type, string rarity)
        {
            _name = name;
            _type = type;
            _rarity = rarity;

            int DamageX = _rarity == "Common" ? 1 : _rarity == "Uncommon" ? 2 : _rarity == "Rare" ? 3 : 5;

            if(_type == "Axe")
            {
                _damage = new Random().Next(5, 11) * DamageX;

                _gamesSoket = new BaseGem[4];
            }

            else if(_type == "Sword")
            {
                _damage = new Random().Next(4, 7) * DamageX;
                _gamesSoket = new BaseGem[3];
            }

            else if(_type == "Knife")
            {
                _damage = new Random().Next(3, 5) * DamageX;
                _gamesSoket = new BaseGem[2];
            }

            else
                throw new ArgumentException($"{_type} invalid value");
        }

        public void AddGem(int index, string clarity, string type)
        {
            if (index < 0 || index > _gamesSoket.Length-1)
                throw new ArgumentOutOfRangeException($"index {index} out");

            if (type == "Amethyst")
                _gamesSoket[index] = new Amethyst(clarity);

            if(type == "Emerald")
                _gamesSoket[index] = new Emerald(clarity);

            if(type == "Ruby")
                _gamesSoket[index] = new Ruby(clarity);


            _damage += _gamesSoket[index].Strength * 2 + _gamesSoket[index].Agility * 2;

            _Strength += _gamesSoket[index].Strength;
            _Agility += _gamesSoket[index].Agility;
            _Vitality += _gamesSoket[index].Vitality;
        }

        public void RemoveGem(int index)
        {
            if (index < 0 || index > _gamesSoket.Length - 1 || _gamesSoket[index] == null)
                throw new Exception($"{index} out of range or element on this index = null");

            _damage -= _gamesSoket[index].Strength * 2 - _gamesSoket[index].Agility * 2;

            _Strength -= _gamesSoket[index].Strength;
            _Agility -= _gamesSoket[index].Agility;
            _Vitality -= _gamesSoket[index].Vitality;

            _gamesSoket[index] = null;
        }

        public override string ToString()
        {
            return $"{Name}: {_damage}, {_Strength} Strength, {_Agility} Agility, {_Vitality} Vitality";
        }
    }
}
