using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UhintsMvc.Dynamic
{
    public class Field : Tuple<string, string>
    {
        public Field(string name, string label) : base(name, label)
        {
            this.IsKey = false;
            this.IsReadOnly = false;
            this.IsVisible = true;
        }

        public bool IsKey { get; set; }

        public bool IsVisible { get; set; }

        public bool IsReadOnly{ get; set; }

        public string Label { get { return this.Item2;  } }

        public string Name {  get { return this.Item1;  } }

    }

    public class KeyField : Field
    {
        public KeyField(string name, string label) : base(name, label)
        {
            this.IsKey = true;
            this.IsVisible = false;
        }
    }

    public class HiddenField : Field
    {
        public HiddenField(string name, string label) : base(name, label)
        {
            this.IsVisible = false;
        }
    }

    public class ActionField : Field
    {
        public ActionField(string name, string label) : base("Action", "Action")
        {

        }

        public ActionField() : base("Action", "Action")
        {

        }

        public string EditAction { get; set; }
        public string DeletAction { get; set; }
    }

    public class TableDescriptor
    {
        public TableDescriptor()
        {
            this.Fields = new List<Field>();
        }

        public TableDescriptor(params Field[] fields) : this()
        {
            foreach(var f in fields)
               this.Fields.Add(f);
        }

        public List<Field> Fields { get; set; }

        public IEnumerator<String> Labels()
        {
            foreach (var f in this.Fields)
                yield return f.Label;
        } 

        public IEnumerator<String> Names()
        {
            foreach (var f in this.Fields)
                yield return f.Name;
        }
 
    }
}