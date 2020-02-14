using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OtherReflectionsExample
{
    public class PropertyInfoExample
    {

        public PropertyInfoExample(string str)
        {
            this.Property1 = str;
        }

        public PropertyInfoExample()
        {           
        }
        public Assembly GetCallingAssemblProperty => Assembly.GetCallingAssembly();

        public Assembly GetExecutingAssemblyProperty => Assembly.GetExecutingAssembly();

        public String Property1
        {
            get;
            private set;
        }

        public String Property2
        {
            get { return "hello"; }
        }

        protected String Property3
        {
            get { return "hello"; }
        }

        private Int32 Property4
        {
            get { return 32; }
        }

        internal String Property5
        {
            get { return "value"; }
        }

        protected internal String Property6
        {
            get { return "value"; }
        }
    }
}
