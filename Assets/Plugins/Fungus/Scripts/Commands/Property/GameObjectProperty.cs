﻿/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/
using UnityEngine;


namespace Fungus
{
    // <summary>
    /// Get or Set a property of a GameObject component
    /// </summary>
    [CommandInfo("Property",
                 "GameObject",
                 "Get or Set a property of a GameObject component")]
    [AddComponentMenu("")]
    public class GameObjectProperty : BaseVariableProperty
    {
		//generated property
        public enum Property 
        { 
            Transform, 
            Layer, 
            ActiveSelf, 
            ActiveInHierarchy, 
            IsStatic, 
            Tag, 
            GameObject, 
        }

		
        [SerializeField]
        protected Property property;
		
        [SerializeField]
        [VariableProperty(typeof(GameObjectVariable))]
        protected GameObjectVariable gameObjectVar;

        [SerializeField]
        [VariableProperty(typeof(TransformVariable),
                          typeof(IntegerVariable),
                          typeof(BooleanVariable),
                          typeof(StringVariable),
                          typeof(GameObjectVariable))]
        protected Variable inOutVar;

        public override void OnEnter()
        {
            var iot = inOutVar as TransformVariable;
            var ioi = inOutVar as IntegerVariable;
            var iob = inOutVar as BooleanVariable;
            var ios = inOutVar as StringVariable;
            var iogo = inOutVar as GameObjectVariable;


            var target = gameObjectVar.Value;

            switch (getOrSet)
            {
                case GetSet.Get:
                    switch (property)
                    {
                        case Property.Transform:
                            iot.Value = target.transform;
                            break;
                        case Property.Layer:
                            ioi.Value = target.layer;
                            break;
                        case Property.ActiveSelf:
                            iob.Value = target.activeSelf;
                            break;
                        case Property.ActiveInHierarchy:
                            iob.Value = target.activeInHierarchy;
                            break;
                        case Property.IsStatic:
                            iob.Value = target.isStatic;
                            break;
                        case Property.Tag:
                            ios.Value = target.tag;
                            break;
                        case Property.GameObject:
                            iogo.Value = target.gameObject;
                            break;
                        default:
                            Debug.Log("Unsupported get or set attempted");
                            break;
                    }

                    break;
                case GetSet.Set:
                    switch (property)
                    {
                        case Property.Layer:
                            target.layer = ioi.Value;
                            break;
                        case Property.IsStatic:
                            target.isStatic = iob.Value;
                            break;
                        case Property.Tag:
                            target.tag = ios.Value;
                            break;
                        default:
                            Debug.Log("Unsupported get or set attempted");
                            break;
                    }

                    break;
                default:
                    break;
            }

            Continue();
        }

        public override string GetSummary()
        {
            if (gameObjectVar == null)
            {
                return "Error: no gameObjectVar set";
            }
            if (inOutVar == null)
            {
                return "Error: no variable set to push or pull data to or from";
            }

            return getOrSet.ToString() + " " + property.ToString();
        }

        public override Color GetButtonColor()
        {
            return new Color32(235, 191, 217, 255);
        }

        public override bool HasReference(Variable variable)
        {
            if (gameObjectVar == variable || inOutVar == variable)
                return true;

            return false;
        }

    }
}