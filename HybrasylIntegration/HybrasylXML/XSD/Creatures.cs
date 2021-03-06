/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2016 Project Hybrasyl (info@hybrasyl.com)
 *
 */

#pragma warning disable

namespace Hybrasyl.XSD
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("mob", Namespace = "http://www.hybrasyl.com/XML/Creatures", IsNullable = false)]
    public partial class Mob
    {
        private Properties _properties;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlAttributeAttribute(AttributeName = "sprite")]
        public ushort Sprite { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool PropertiesSpecified { get; set; }

        [XmlIgnore()]
        public bool SpriteSpecified { get; set; }

        [XmlElementAttribute("properties")]
        public Properties Properties
        {
            get
            {
                if ((_properties == null))
                {
                    _properties = new Properties();
                }
                return _properties;
            }
            set
            {
                _properties = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("Properties")]
    public partial class Properties
    {
        private PropertiesDifficulty _difficulty;

        private PropertiesDamage _damage;

        private PropertiesDefense _defense;

        private Loot _loot;

        [XmlElementAttribute("scriptname")]
        public object Scriptname { get; set; }

        [XmlIgnore()]
        public bool DifficultySpecified { get; set; }

        [XmlIgnore()]
        public bool DamageSpecified { get; set; }

        [XmlIgnore()]
        public bool DefenseSpecified { get; set; }

        [XmlIgnore()]
        public bool LootSpecified { get; set; }

        [XmlIgnore()]
        public bool ScriptnameSpecified { get; set; }

        [XmlElementAttribute("difficulty")]
        public PropertiesDifficulty Difficulty
        {
            get
            {
                if ((_difficulty == null))
                {
                    _difficulty = new PropertiesDifficulty();
                }
                return _difficulty;
            }
            set
            {
                _difficulty = value;
            }
        }

        [XmlElementAttribute("damage")]
        public PropertiesDamage Damage
        {
            get
            {
                if ((_damage == null))
                {
                    _damage = new PropertiesDamage();
                }
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        [XmlElementAttribute("defense")]
        public PropertiesDefense Defense
        {
            get
            {
                if ((_defense == null))
                {
                    _defense = new PropertiesDefense();
                }
                return _defense;
            }
            set
            {
                _defense = value;
            }
        }

        [XmlElementAttribute("loot")]
        public Loot Loot
        {
            get
            {
                if ((_loot == null))
                {
                    _loot = new Loot();
                }
                return _loot;
            }
            set
            {
                _loot = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("PropertiesDifficulty")]
    public partial class PropertiesDifficulty
    {
        [XmlAttributeAttribute(AttributeName = "level")]
        public byte Level { get; set; }

        [XmlAttributeAttribute(AttributeName = "multiplier")]
        [DefaultValueAttribute(typeof(float), "1")]
        public float Multiplier { get; set; }

        [XmlAttributeAttribute(AttributeName = "speed")]
        [DefaultValueAttribute(typeof(float), "1")]
        public float Speed { get; set; }

        [XmlIgnore()]
        public bool LevelSpecified { get; set; }

        [XmlIgnore()]
        public bool MultiplierSpecified { get; set; }

        [XmlIgnore()]
        public bool SpeedSpecified { get; set; }

        public PropertiesDifficulty()
        {
            Multiplier = ((float)(1F));
            Speed = ((float)(1F));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("dropset", Namespace = "http://www.hybrasyl.com/XML/Creatures", IsNullable = false)]
    public partial class Dropset
    {
        private List<object> _drops;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DropsSpecified { get; set; }

        [XmlArrayItemAttribute("gold", typeof(DropGold), IsNullable = false, ElementName = "drops")]
        [XmlArrayItemAttribute("item", typeof(DropItem), IsNullable = false)]
        public List<object> Drops
        {
            get
            {
                if ((_drops == null))
                {
                    _drops = new List<object>();
                }
                return _drops;
            }
            set
            {
                _drops = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("DropGold")]
    public partial class DropGold
    {
        [XmlAttributeAttribute(AttributeName = "minqty")]
        [DefaultValueAttribute(typeof(byte), "1")]
        public byte Minqty { get; set; }

        [XmlAttributeAttribute(AttributeName = "maxqty")]
        [DefaultValueAttribute(typeof(byte), "1")]
        public byte Maxqty { get; set; }

        [XmlAttributeAttribute(AttributeName = "chance")]
        [DefaultValueAttribute(typeof(float), "1")]
        public float Chance { get; set; }

        [XmlIgnore()]
        public bool MinqtySpecified { get; set; }

        [XmlIgnore()]
        public bool MaxqtySpecified { get; set; }

        [XmlIgnore()]
        public bool ChanceSpecified { get; set; }

        public DropGold()
        {
            Minqty = ((byte)(1));
            Maxqty = ((byte)(1));
            Chance = ((float)(1F));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("DropItem")]
    public partial class DropItem
    {
        [XmlAttributeAttribute(AttributeName = "minqty")]
        [DefaultValueAttribute(typeof(byte), "1")]
        public byte Minqty { get; set; }

        [XmlAttributeAttribute(AttributeName = "maxqty")]
        [DefaultValueAttribute(typeof(byte), "1")]
        public byte Maxqty { get; set; }

        [XmlAttributeAttribute(AttributeName = "chance")]
        [DefaultValueAttribute(typeof(float), "1")]
        public float Chance { get; set; }

        [XmlAttributeAttribute(AttributeName = "variant")]
        [DefaultValueAttribute("none")]
        public string Variant { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }

        [XmlIgnore()]
        public bool MinqtySpecified { get; set; }

        [XmlIgnore()]
        public bool MaxqtySpecified { get; set; }

        [XmlIgnore()]
        public bool ChanceSpecified { get; set; }

        [XmlIgnore()]
        public bool VariantSpecified { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }

        public DropItem()
        {
            Minqty = ((byte)(1));
            Maxqty = ((byte)(1));
            Chance = ((float)(1F));
            Variant = "none";
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("Drop")]
    public partial class Drop
    {
        private List<object> _items;

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("gold", typeof(DropGold))]
        [XmlElementAttribute("item", typeof(DropItem))]
        public List<object> Items
        {
            get
            {
                if ((_items == null))
                {
                    _items = new List<object>();
                }
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("Loot")]
    public partial class Loot
    {
        private List<object> _items;

        [XmlAttributeAttribute(AttributeName = "exp")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Exp { get; set; }

        [XmlAttributeAttribute(AttributeName = "gold")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Gold { get; set; }

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlIgnore()]
        public bool ExpSpecified { get; set; }

        [XmlIgnore()]
        public bool GoldSpecified { get; set; }

        public Loot()
        {
            Exp = ((uint)(0));
            Gold = ((uint)(0));
        }

        [XmlElementAttribute("drops", typeof(Drop))]
        [XmlElementAttribute("dropset", typeof(string))]
        public List<object> Items
        {
            get
            {
                if ((_items == null))
                {
                    _items = new List<object>();
                }
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("PropertiesDamage")]
    public partial class PropertiesDamage
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        public uint Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        public uint Max { get; set; }

        [XmlAttributeAttribute(AttributeName = "element")]
        [DefaultValueAttribute(Element.none)]
        public Element Element { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        [XmlIgnore()]
        public bool ElementSpecified { get; set; }

        public PropertiesDamage()
        {
            Element = Element.none;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Creatures")]
    [XmlRootAttribute("PropertiesDefense")]
    public partial class PropertiesDefense
    {
        [XmlAttributeAttribute(AttributeName = "mr")]
        [DefaultValueAttribute(typeof(byte), "1")]
        public byte Mr { get; set; }

        [XmlAttributeAttribute(AttributeName = "ac")]
        public byte Ac { get; set; }

        [XmlAttributeAttribute(AttributeName = "element")]
        [DefaultValueAttribute(Element.none)]
        public Element Element { get; set; }

        [XmlIgnore()]
        public bool MrSpecified { get; set; }

        [XmlIgnore()]
        public bool AcSpecified { get; set; }

        [XmlIgnore()]
        public bool ElementSpecified { get; set; }

        public PropertiesDefense()
        {
            Mr = ((byte)(1));
            Element = Element.none;
        }
    }
}

#pragma warning restore