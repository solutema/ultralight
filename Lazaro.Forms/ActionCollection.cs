﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms
{
        public class ActionCollection : System.Collections.CollectionBase
        {
                public Form ParentForm;

                public ActionCollection(Form parentForm)
                {
                        this.ParentForm = parentForm;
                }

                public void Add(Action action)
                {
                        action.ParentForm = this.ParentForm;
                        this.List.Add(action);
                }

                public void Remove(string actionName)
                {
                        for (int i = 0; i < this.Count; i++) {
                                if (this[i].Name == actionName) {
                                        this.RemoveAt(i);
                                        break;
                                }
                        }
                }

                public virtual Action this[int index]
		{
			get
			{
				return (Action)this.List[index];
			}
			set
			{
                                value.ParentForm = this.ParentForm;
				this[index] = value;
			}
		}

                public Action this[string actionName]
		{
                        get
			{
				foreach(Action Act in this) {
					if(Act.Name == actionName)
						return Act;
				}
				return null;
			}
			set
			{
                                if (value == null) {
                                        this.Remove(actionName);
                                } else {
                                        bool Encontrado = false;
                                        for (int i = 0; i < this.Count; i++) {
                                                if (this[i].Name == actionName) {
                                                        this[i] = value;
                                                        Encontrado = true;
                                                        break;
                                                }
                                        }
                                        if (Encontrado == false) {
                                                //Si no existe, lo agrego
                                                this.Add(value);
                                        }
                                }
			}
                }

                public bool Contains(string actionName)
                {
                        foreach (Action Act in this) {
                                if (Act.Name == actionName)
                                        return true;
                        }
                        return false;
                }

                public override string ToString()
                {
                        string Res = "ActionCollection[" + this.Count.ToString() + "] = {";
                        string FlList = null;
                        foreach (Action Act in this) {
                                if (FlList == null)
                                        FlList = "";
                                else
                                        FlList += ", ";
                                FlList += Act.ToString();
                        }

                        return Res + FlList + "}";
                }

                public Action AcceptAction
                {
                        get
                        {
                                return this["accept"];
                        }
                        set
                        {
                                this["accept"] = value;
                        }
                }

                public Action CancelAction
                {
                        get
                        {
                                return this["cancel"];
                        }
                        set
                        {
                                this["cancel"] = value;
                        }
                }
        }
}