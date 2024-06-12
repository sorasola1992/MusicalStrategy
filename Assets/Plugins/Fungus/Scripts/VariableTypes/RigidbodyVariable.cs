﻿// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/

using UnityEngine;

namespace Fungus
{
    /// <summary>
    /// Rigidbody variable type.
    /// </summary>
    [VariableInfo("Other", "Rigidbody")]
    [AddComponentMenu("")]
    [System.Serializable]
    public class RigidbodyVariable : VariableBase<UnityEngine.Rigidbody>
    { }

    /// <summary>
    /// Container for a Rigidbody variable reference or constant value.
    /// </summary>
    [System.Serializable]
    public struct RigidbodyData
    {
        [SerializeField]
        [VariableProperty("<Value>", typeof(RigidbodyVariable))]
        public RigidbodyVariable rigidbodyRef;

        [SerializeField]
        public UnityEngine.Rigidbody rigidbodyVal;

        public static implicit operator UnityEngine.Rigidbody(RigidbodyData RigidbodyData)
        {
            return RigidbodyData.Value;
        }

        public RigidbodyData(UnityEngine.Rigidbody v)
        {
            rigidbodyVal = v;
            rigidbodyRef = null;
        }

        public UnityEngine.Rigidbody Value
        {
            get { return (rigidbodyRef == null) ? rigidbodyVal : rigidbodyRef.Value; }
            set { if (rigidbodyRef == null) { rigidbodyVal = value; } else { rigidbodyRef.Value = value; } }
        }

        public string GetDescription()
        {
            if (rigidbodyRef == null)
            {
                return rigidbodyVal != null ? rigidbodyVal.ToString() : "Null";
            }
            else
            {
                return rigidbodyRef.Key;
            }
        }
    }
}