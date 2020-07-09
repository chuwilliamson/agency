﻿using UnityEngine;

namespace ChuTools.Scripts
{
    [CreateAssetMenu(menuName = "Variables/StringVariable")]
    public class StringVariable : ScriptableObject
    {
        [SerializeField]
        private string value;

        public string Value
        {
            get => value;
            set => this.value = value;
        }
    }
}