﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MikuMikuLibrary.CharacterItem;

namespace MikuMikuModel.Nodes.CharacterItem
{
    class CostumeNode : Node<Costume>
    {
        public override NodeFlags Flags => NodeFlags.None;
        [Category("General")]
        public List<int> Parts => GetProperty<List<int>>();
        [Category("General")]
        public int CostumeID
        {
            get => GetProperty<int>();
            set => SetProperty<int>(value);
        }

        protected override void Initialize()
        {
        }

        protected override void PopulateCore()
        {
        }

        protected override void SynchronizeCore()
        {
        }

        public CostumeNode(string name, Costume data) : base(name, data)
        {
        }
    }
}
